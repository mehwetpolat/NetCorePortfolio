using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Portfolyo.Areas.Writer.Models
{
    
    public class UserLoginViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı Adınızı Giriniz")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifrenizi Giriniz")]
        public string Password { get; set; }
    }
}
