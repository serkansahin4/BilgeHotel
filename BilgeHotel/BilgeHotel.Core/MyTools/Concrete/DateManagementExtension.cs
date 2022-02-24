using BilgeHotel.Core.MyTools.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Core.MyTools.Concrete
{
    public class DateManagementExtension : IDateManagementExtension
    {
        
        public List<DateTime> BaslangicTarihleri(List<DateEntity> dates)
        {
            List<DateTime> musaitZaman = new List<DateTime>();
            #region Rezervasyon Tarihlerini Tuttuğumuz yer.

            List<DateTime> dateTimes = new List<DateTime>();
            foreach (var item in dates)
            {
                DateTime itemDateBaslangic = item.Baslangic;
                DateTime itemDateBitis = item.Bitis;
                for (DateTime tarih = itemDateBaslangic; tarih <= itemDateBitis; tarih = tarih.AddDays(1))
                {
                    dateTimes.Add(tarih);
                }
                dateTimes.Add(itemDateBitis);
            }
            #endregion //


            #region Rezervasyon Tarihlerini, İlk 6 Aydaki rezervasyonlardan çıkarttığımız kısım
            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 0, 0);
            DateTime endDate = new DateTime(startDate.Year, startDate.AddMonths(6).Month, startDate.AddDays(1).Day, 10, 0, 0);

            for (DateTime tarih = startDate; tarih <= endDate; tarih = tarih.AddDays(1))
            {
                musaitZaman.Add(tarih);
            }
            foreach (DateTime item in dateTimes)
            {
                musaitZaman.Remove(item);
            }
          
            #endregion
            return musaitZaman;
        }

        public List<DateTime> BitisTarihleri(List<DateTime> dates,DateTime seciliTarih)
        {
            #region Rezervasyon başlangıç tarihi seçildiğinde bitiş tarihlerini hesaplayan kısım.
            List<DateTime> bitisTarihleri = new List<DateTime>();
            
            foreach (DateTime item in dates)
            {
                if (item == seciliTarih)
                {
                    seciliTarih = seciliTarih.AddDays(1);
                    
                    bitisTarihleri.Add(new DateTime(seciliTarih.Year, seciliTarih.Month, seciliTarih.Day, 10, 0, 0));
                    
                }
                
            }
            #endregion

            return bitisTarihleri;
        }
    }
}
