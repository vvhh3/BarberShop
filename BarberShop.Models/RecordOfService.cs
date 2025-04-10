using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarberShop.Models;

public class RecordOfService
{
    [Key]public int Id { get; set; }
    
    public int? ServiceId { get; set; }
    [ForeignKey("ServiceId")] public Service? Service { get; set; }   
    public int? ClientId { get; set; }
    [ForeignKey("ClientId")] public Client? Client { get; set; }    
    
    public int? MasterId { get; set; }
    [ForeignKey("MasterId")] public Master? Master { get; set; }

    [Required(ErrorMessage = "Дата обязательна")]public DateTime DateOfRecord { get; set; } = DateTime.Today;


    [Required(ErrorMessage = "Время обязательно")]
    public DateTime TimeOfRecord { get; set; } = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,10,00,0);
}