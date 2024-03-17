using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class AdminMoneyCollection
{
    [Key]
    public int Id { get; set; }
    public int RegistrationId { get; set; }
    public Registration Registration { get; set; }
    public decimal CollectionAmount { get; set; }
    public string Description { get; set; }
    public DateTime InsertDateUtc { get; set; }
}