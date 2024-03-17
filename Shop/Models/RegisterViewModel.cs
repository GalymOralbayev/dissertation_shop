using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class RegisterViewModel
    {
        [Required (ErrorMessage = "Поле email не заполнено")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле пароль не заполнено")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Поле подтвердить пароль не заполнено")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
        [Required(ErrorMessage = "Поле номер телефона не заполнено")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Поле интересы не заполнено")]
        public string Interests { get; set; }

        [Required(ErrorMessage = "Поле профессия не заполнено")]
        public string Profession { get; set; }

        [Required(ErrorMessage = "Поле дата рождения не заполнено")]
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
