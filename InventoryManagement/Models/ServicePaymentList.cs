using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public partial class ServicePaymentList
{
    [Key]
    public int Id { get; set; }
    public int SellingPaymentId { get; set; }
    public int ServiceId { get; set; }
    public decimal ServicePaidAmount { get; set; }
    public DateTime InsertDate { get; set; }
    public virtual SellingPayment SellingPayment { get; set; }
    public virtual Service Service { get; set; }
}
