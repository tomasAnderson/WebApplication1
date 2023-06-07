using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class ContactModel
{
    [Display(Name = "Введите имя")]
    [Required(ErrorMessage = "Это поле обязательно к заполнению")]
    public string Name { get; set; }
    [Display(Name = "Введите фамилию")]
    public string SurnameName { get; set; }
    [Display(Name = "Введите возраст")]
    public int Age { get; set; }
    [Display(Name = "Введите почту")]
    public string Email { get; set; }
    [Display(Name = "Введите сообщение")]
    public string Message { get; set; }
    [Display(Name = "Введите пароль")]
    public string Password { get; set; }
}