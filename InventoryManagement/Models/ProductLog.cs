using System.ComponentModel.DataAnnotations;
using InventoryManagement.Enums;

namespace InventoryManagement.Models;

public class ProductLog
{
    [Key]
    public int Id { get; set; }
    public int ProductStockId { get; set; }
    public ProductStock ProductStock { get; set; }
    public string Details { get; set; }
    public ProductLogStatus LogStatus { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public int? SellingId { get; set; }
    public int? PurchaseId { get; set; }
    public virtual Selling Selling { get; set; }
    public virtual Purchase Purchase { get; set; }
}