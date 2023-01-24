using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace arabaSizin.Models
{
    public class ProfilGuncelle
    {
        public string id { get; set; }
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
        [EmailAddress(ErrorMessage = "Geçerli Email Adresi Giriniz!")]
        public string email { get; set; }
    }
}