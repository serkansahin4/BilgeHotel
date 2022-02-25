using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface ICardService
    {
        [Obsolete("Bu Metodu Kullanma, Tek başına card verisi bir anlam ifade etmiyor.")]
        Task<bool> Add(Card card); //ReservationDetail oluşturulurken bir cart eklenmesi gerekiyor. Bu yüzden oluşturdum
                                   //Ancak bu card bilgisi tek başına bir anlam ifade etmiyor.
                                   //Bu yüzden ekleme metodu apide bulunmayacak.
                                   //Proje geliştikce bunun farkına vardım. Bu yüzden kodlar gelişe gelişe ilerliyor
                                   //Sonraki adımlarda yeni öğrendiğim şeyleri uygulayarak devam ediyorum.
                                   //Başlangıçtan ne kadar uzaklaştığımı görebilmek için.
        List<Card> GetAll();
        Card GetById(Guid id);
        Task<bool> DeleteByIdAsync(Guid id);

    }
}
