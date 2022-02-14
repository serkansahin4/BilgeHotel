using BilgeHotel.Core.MyTools.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Core.MyTools.Abstract
{
    public interface IDateManagementExtension
    {
        List<DateTime> BaslangicTarihleri(List<DateEntity> dates);
        List<DateTime> BitisTarihleri(List<DateTime> dates,DateTime dateTime);
    }
}
