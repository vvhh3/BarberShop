using System.ComponentModel.DataAnnotations;

namespace BarberShop.Models;

public class Service
{
    [Key] public int Id { get; set; }
    [Required(ErrorMessage = "Название услуги обязательно к заполнению")] public string Title { get; set; }
    [Required(ErrorMessage = "Описание обязателено к заполнению")] public string Description { get; set; }
    [Required(ErrorMessage = "Цена обязательна к заполнению")] public decimal Price { get; set; }
}