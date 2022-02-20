using BankApi.Models;
using BankApi.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinansController : ControllerBase
    {
        private static List<Card> Cards = new List<Card> {
        new Card{ KartNo="FFFFFFFFFF", CV2="FFF", EndDate="1234", Mail="serkana607@gmail.com", Balance=35000},
        new Card{ KartNo="IIIIIIIIII", CV2="III", EndDate="1234", Mail="serkana607@gmail.com", Balance=3500},
        new Card{ KartNo="NNNNNNNNNN", CV2="NNN", EndDate="1234", Mail="serkana607@gmail.com", Balance=2550}
        };


        private static List<Transaction> data = new List<Transaction>();

        public string Get()
        {
            return "ss";
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult PayPost([FromBody] PayVM payVM)
        {
            Card card = Cards.SingleOrDefault(x => x.KartNo == payVM.CardNo && x.CV2 == payVM.CV2 && x.EndDate == payVM.EndDate);
            if (card != null)
            {
                Guid confirmationGuid = Guid.NewGuid();
                data.Add(new Transaction { CardNo = card.KartNo, Amount = payVM.Amount, Confirmation = false, TransactionAdress = confirmationGuid });
                MailSender.MailSend(card.Mail, "Finans Bankası Onaylama Kodu", $"Toplam Tutar = {payVM.Amount} Onaylama Idsi = {confirmationGuid}");
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult GuidPost([FromBody] Guid guid)
        {
            Transaction transaction = data.SingleOrDefault(x => x.TransactionAdress == guid);
            if (transaction != null)
            {
                transaction.Confirmation = true;
                Card card = Cards.SingleOrDefault(x => x.KartNo == transaction.CardNo);
                card.Balance -= transaction.Amount;
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
