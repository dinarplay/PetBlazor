using System.ComponentModel.DataAnnotations;

namespace PetBlazor.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 50 символов")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Неправильный формат ввода email'а")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string PasswordConfirm { get; set; }

        public int RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
