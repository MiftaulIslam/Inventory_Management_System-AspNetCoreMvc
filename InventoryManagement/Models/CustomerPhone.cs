using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class CustomerPhone
{
    [Key]
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
    public string Phone { get; set; }
    public bool? IsPrimary { get; set; }
    public DateTime InsertDate { get; set; }
}
