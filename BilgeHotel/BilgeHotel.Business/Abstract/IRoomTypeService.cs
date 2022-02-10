﻿using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IRoomTypeService
    {
        List<RoomType> GetAll();
        RoomType Get(int id);
    }
}