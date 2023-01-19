using System.ComponentModel.DataAnnotations;

namespace DbMvcApp.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Поле Email не может быть пустым")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле пароль не может быть пустым")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}
