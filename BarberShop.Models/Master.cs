using System.ComponentModel.DataAnnotations;

namespace BarberShop.Models;

public class Master
{
    [Key] public int Id { get; set; }

    [Required(ErrorMessage = "Имя обязательно к заполнению")]
    public string Name { get; set; } = "";
    [Required(ErrorMessage = "Опыт обязателен к заполнению")] public int Experience { get; set; }
    [Required(ErrorMessage = "Профессия обязательна к заполнению")] public string Profession { get; set; }
}