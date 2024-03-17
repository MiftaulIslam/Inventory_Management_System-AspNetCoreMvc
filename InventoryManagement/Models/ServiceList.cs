using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public partial class ServiceList
{
    [Key]
    public int Id { get; set; }
    public int ServiceId { get; set; }
    public int ServiceDeviceId { get; set; }
    public decimal ServiceCharge { get; set; }
    public string Problem { get; set; }
    public string Solution { get; set; }
    public DateTime InsertDate { get; set; }
    public virtual Service Service { get; set; }
    public virtual ServiceDevice ServiceDevice { get; set; }
}
