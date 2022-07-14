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
        public static string AuthorizationDenied = " ";
        public static string UserRegistered = " ";
        public static string UserNotFound = " ";
        public static string SuccessfulLogin = " ";
        public static string PasswordError = " ";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = " ";
    }
}

