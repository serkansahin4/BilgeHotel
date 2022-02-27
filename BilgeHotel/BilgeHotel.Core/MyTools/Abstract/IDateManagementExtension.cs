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
        List<DateTime> BaslangicTarihleri(List<DateEntity> dates); //dates=> Rezervasyon Tarihleri. return=> müsait rezervasyon tarihleri.
        List<DateTime> BitisTarihleri(List<DateTime> dates,DateTime dateTime); //DATES=> BAŞLANGIÇ TARİHLERİNDEN DÖNEN LİSTE
                                                                               //dateTime=> Başlangıç Tarihi
    }
}
