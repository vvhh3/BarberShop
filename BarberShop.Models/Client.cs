using System.ComponentModel.DataAnnotations;

namespace BarberShop.Models;

public class Client
{
    [Key] public int Id { get; set; }
    
    [Required(ErrorMessage = "Имя обязательна к заполнению")]public string Name { get; set; }
    [Required(ErrorMessage = "Телефон обязателен к заполнению")]public double Phone { get; set; }
    [Required(ErrorMessage = "Почта обязательнф к заполнению")]public string Email { get; set; }
}