﻿using System.ComponentModel.DataAnnotations;

namespace CorePortfolio.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Lütfen Soyadınızı Girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Resim Url  Girin")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Sifrenizi Girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Girin")]

        [Compare("Password", ErrorMessage ="Şifreler uyumlu değil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Girin")]
        public string Mail { get; set; }
    }
}
