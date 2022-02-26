using BilgeHotel.Business.Abstract;
using BilgeHotel.CacheReservation;
using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
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
        public ReservationsController(IReservationService reservationService, IPackageService packageService, IRoomService roomService, ICustomerService customerService)
        {
            _reservationService = reservationService;
            _packageService = packageService;
            _roomService = roomService;
            _customerService = customerService;
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
            DateTime checkInDate = new DateTime(createVM.CheckInDate.Year, createVM.CheckInDate.Month, createVM.CheckInDate.Day, 14, 0, 0);
            DateTime checkOutDate = new DateTime(createVM.CheckOutDate.Year, createVM.CheckOutDate.Month, createVM.CheckOutDate.Day, 10, 0, 0);

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

                reservation.ReservationDetails.Add(new ReservationDetail { Discount = 1, DiscountedPrice = sumPrice, ReservationId = reservationId, CheckInDate = createVM.CheckInDate, CheckOutDate = createVM.CheckOutDate, CreatedDate = createVM.CreatedDate, PackageId = createVM.PackageId, RoomId = createVM.RoomId });

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
    }
}
