using System.ComponentModel.DataAnnotations;

namespace DataSourcesApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Имя обязательно")]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Range(1, 120, ErrorMessage = "Возраст от 1 до 120")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Display(Name = "Группа")]
        public string Group { get; set; }

        [Display(Name = "Город")]
        public string City { get; set; }

        // ===== Задание 1. Email =====
        [EmailAddress(ErrorMessage = "Некорректный email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
