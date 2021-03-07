using Core.Entities.Concrete;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvaild = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Kategorideki ürün sayısı aşıldı";
        public static string ProductNameAlreadyExists="Bu isimde ürün mevcut";
        public static string CategoryCountFull="kategori sayısı dolu";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string PasswordError="Şifre hatalı";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string UserRegistered="kullanıcı kayıt oldu";
        public static string AccessTokenCreated="Token oluşturuldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
    }
}
