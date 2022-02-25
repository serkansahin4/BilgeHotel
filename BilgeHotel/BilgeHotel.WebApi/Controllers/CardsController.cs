using BilgeHotel.Business.Abstract;
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
    public class CardsController : ControllerBase
    {
        private readonly ICardService _cardService;
        public CardsController(ICardService service)
        {
            _cardService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            Card card = _cardService.GetById(id);
            if (card != null)
            {
                CardVM cardVM = new CardVM();
                cardVM.Id = card.Id;
                cardVM.CardNumber = card.CardNumber;
                cardVM.CV2 = card.Cv2;
                cardVM.EndDate = card.EndDate;
                cardVM.CardType = card.CardType;
                return Ok(cardVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<CardVM> cards = _cardService.GetAll().Select(x => new CardVM { Id = x.Id, EndDate=x.EndDate, CardNumber=x.CardNumber, CV2=x.Cv2, CardType = x.CardType }).ToList();
            return Ok(cards);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            bool kontrol = await _cardService.DeleteByIdAsync(id);
            if (kontrol == true)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
