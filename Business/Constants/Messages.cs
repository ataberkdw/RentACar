using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun Eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime = "Bakim Saati";
        public static string ProductListed = "Urunler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 urun olmak zorundadur";
        public static string ProductNameAlreadyExits = "Eklenen isimde zaten bir urun var";
        public static string CountOfCategoryError = "Kategori sayisi gerekenden fazla";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string AccessTokenCreated = "Access Token olusturuldu";
        public static string UserNotFound = "Kullanici Bulunamadi";
        public static string PasswordError = "Sifre Hatali";
        public static string SuccessfulLogin = "Giris Basarili";
        public static string UserRegistered = "Kullanici Kayit Oldu";
        public static string UserAlreadyExists = "Kullanici Coktan Cikti";
        public static string ProductUpdated = "Urun Guncellendi";
    }
}
