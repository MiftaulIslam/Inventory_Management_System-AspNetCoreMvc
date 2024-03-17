using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public partial class SellingAdjustment
{
    [Key]
    public int Id { get; set; }
    public int RegistrationId { get; set; }
    public int ProductId { get; set; }
    public int SellingId { get; set; }
    public int ProductStockId { get; set; }
    public string AdjustmentStatus { get; set; }
    public DateTime InsertDate { get; set; }
    public virtual Product Product { get; set; }
    public virtual ProductStock ProductStock { get; set; }
    public virtual Registration Registration { get; set; }
    public virtual Selling Selling { get; set; }
}
