using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace arabaSizin.Models
{
    public class SifreDegistir
    {
        [Required]
        [DisplayName("Eski Şifre")]
        public string oldPassword { get; set; }

        [Required]
        [DisplayName("Yeni Şifre")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Şifreniz En Az 5 Karakter Olmalıdır!")]
        public string newPassword { get; set; }

        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("newPassword", ErrorMessage = "Şifreler Aynı Değil!")]
        public string conNewPassword { get; set; }
    }
}