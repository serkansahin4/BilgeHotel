﻿using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface ICustomerService
    {
        [Obsolete("Bu Müşteri Kendi Başına Bir Anlam İfade Etmiyor. Bu yüzden Ara Tablo Üzerinden Ekleme Yapın.")]
        Task<bool> Add(Customer customer);

        List<Customer> GetAll();
        Customer GetById(int id);
        Task<bool> DeleteByIdAsync(int id);
    }
}
