﻿using BilgeHotel.Business.Abstract;
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
    }
}