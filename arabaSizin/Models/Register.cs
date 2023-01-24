using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace arabaSizin.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Ad")]
        public string name { get; set; }
        [Required]
        [DisplayName("Soyad")]
        public string surname { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string userName { get; set; }
        [Required]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Geçersiz Email Adresi!")]
        public string email { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string password { get; set; }
        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("password", ErrorMessage = "Şifreler Eşleşmiyor!")]
        public string rePassword { get; set; }

    }
}