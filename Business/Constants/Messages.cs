using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım Zamanı";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceeded = "Kategori Limiti Aşıldı";
        public static string AuthorizationDenied = "Yetkisiz Kullanıcı";
        public static string UserRegistered = "Kullanıcı Kaydı Başarılı";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string PasswordError = "Hatalı Parola";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}

