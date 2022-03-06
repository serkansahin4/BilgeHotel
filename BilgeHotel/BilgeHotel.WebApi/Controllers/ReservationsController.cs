using BilgeHotel.Business.Abstract;
using BilgeHotel.CacheReservation;
using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using BilgeHotel.Entities.DTO;
using BilgeHotel.WebApi.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        private readonly IPackageService _packageService;
        private readonly IRoomService _roomService;
        private readonly ICustomerService _customerService;
        private readonly IReservationDetailService _reservationDetailService;
        public ReservationsController(IReservationService reservationService, IPackageService packageService, IRoomService roomService, ICustomerService customerService, IReservationDetailService reservationDetailService)
        {
            _reservationService = reservationService;
            _packageService = packageService;
            _roomService = roomService;
            _customerService = customerService;
            _reservationDetailService = reservationDetailService;
        }

        [HttpGet("ControlGet/{dTO}")]
        public IActionResult ControlGet([FromBody] ReservationControlDTO dTO)
        {
           
            DateTime checkInDate = new DateTime(dTO.CheckInDate.Year, dTO.CheckInDate.Month, dTO.CheckInDate.Day, 14, 0, 0);   //Kullanıcıdan gelen saat salise ve saniyeyi
            DateTime checkOutDate = new DateTime(dTO.CheckOutDate.Year, dTO.CheckOutDate.Month, dTO.CheckOutDate.Day, 10, 0, 0); //Düzeltmek zorundayız.
            
            List<ReservationControlDTO> reservations = _reservationDetailService.GetAll(dTO.roomId).Select(x => new ReservationControlDTO
            {
                CheckInDate = x.CheckInDate,
                CheckOutDate = x.CheckOutDate,
                roomId = x.RoomId
            }).ToList();

            bool reservationKontrol = _reservationService.Control(reservations, checkInDate, checkOutDate, dTO.roomId); //Veritabanında Reservasyon detaylar
            return Ok(reservationKontrol);
        }


        [HttpGet("{reservationId}")]
        public IActionResult ReservationOutHotelExtraPriceGet(Guid reservationId)
        {
            return Ok(_reservationService.ReservationExtraPrice(reservationId));
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> ReservationOutPost(Guid reservationId)
        {
            bool kontrol = await _reservationService.ReservationExtraPayment(reservationId);
            if (kontrol)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> ReservationPost([FromBody] ReservationCreateVM createVM)
        {
            DateTime checkInDate = new DateTime(createVM.CheckInDate.Year, createVM.CheckInDate.Month, createVM.CheckInDate.Day, 14, 0, 0);   //Kullanıcıdan gelen saat salise ve saniyeyi
            DateTime checkOutDate = new DateTime(createVM.CheckOutDate.Year, createVM.CheckOutDate.Month, createVM.CheckOutDate.Day, 10, 0, 0); //Düzeltmek zorundayız.

            List<ReservationControlDTO> reservations = _reservationDetailService.GetAll(createVM.RoomId).Select(x => new ReservationControlDTO
            {
                CheckInDate = x.CheckInDate,
                CheckOutDate = x.CheckOutDate,
                roomId = x.RoomId
            }).ToList();

            bool reservationKontrol = _reservationService.Control(reservations, checkInDate, checkOutDate, createVM.RoomId); //Veritabanında Reservasyon detaylar
                                                                                                                             //içerisinde bu odaya ve bu tarihlere ait rezervasyon
                                                                                                                             //varmı yokmu kontrol ediyor.
            if (reservationKontrol)
            {


                ReservationCacheExtension cache = new ReservationCacheExtension();
                Guid cacheIdentity = Guid.NewGuid();
                bool cacheKontrol = cache.CacheInAdd(new ReservationCacheDTO { CheckInDate = checkInDate, CheckOutDate = checkOutDate, RoomId = createVM.RoomId, ReservationIdentity = cacheIdentity });
                Customer customer = _customerService.GetByIdentity(createVM.Customer.TcIdentityNo);

                if (cacheKontrol)
                {
                    double packagePrice = _packageService.PriceGetById(createVM.PackageId);
                    double roomPrice = _roomService.PriceGetById(createVM.RoomId);
                    double sumPrice = packagePrice + roomPrice;

                    Guid reservationId = Guid.NewGuid();
                    Reservation reservation = new Reservation();
                    reservation.Id = reservationId;
                    if (customer == null) //TC KİMLİK NOYA GÖRE
                    {
                        reservation.Customer = createVM.Customer;
                    }
                    else
                    {
                        reservation.CustomerId = customer.Id;
                    }
                    reservation.EmployeeId = createVM.EmployeeId;

                    reservation.ReservationDetail=new ReservationDetail { Discount = 1, DiscountedPrice = sumPrice, ReservationId = reservationId, CheckInDate = checkInDate, CheckOutDate = checkOutDate, CreatedDate = createVM.CreatedDate, PackageId = createVM.PackageId, RoomId = createVM.RoomId };

                    bool kontrol = await _reservationService.Add(reservation);
                    if (kontrol)
                    {

                        return Ok();
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }


        }
    }
}
