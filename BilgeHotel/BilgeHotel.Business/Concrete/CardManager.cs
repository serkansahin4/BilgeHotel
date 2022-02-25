using BilgeHotel.Business.Abstract;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Concrete
{
    public class CardManager : ICardService
    {
        private readonly IRepository<Card> _repository;
        public CardManager(IRepository<Card> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Add(Card card)
        {
            await _repository.Insert(card);
            return true;
        }

        public async Task<bool> DeleteByIdAsync(Guid id)
        {
            Card card = _repository.Get(x => x.Id == id);
            bool kontrol = await _repository.Delete(card);
            return kontrol;
        }

        public List<Card> GetAll()
        {
            return _repository.GetAll();
        }

        public Card GetById(Guid id)
        {
            return _repository.Get(x => x.Id == id);
        }
    }
}
