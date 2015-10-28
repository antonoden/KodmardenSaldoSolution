using System.ComponentModel.DataAnnotations;

namespace KodmardenSaldo.Web.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter Username")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}