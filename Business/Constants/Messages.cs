using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public class Messages
    {
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string UserRegistered = "Kayıt olundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı parola girildi";

        public static string UserAlreadyExists = "Kullanıcı mevcut";

        public static string AuthorizationDenied = "Yetki dışı işlem";

        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
