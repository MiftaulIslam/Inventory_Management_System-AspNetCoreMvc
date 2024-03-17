using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public partial class SellingPaymentList
{
    [Key]
    public int Id { get; set; }
    public int SellingPaymentId { get; set; }
    public int SellingId { get; set; }
    public decimal SellingPaidAmount { get; set; }
    public decimal AccountTransactionCharge { get; set; }
    public DateTime InsertDate { get; set; }
    public virtual Selling Selling { get; set; }
    public virtual SellingPayment SellingPayment { get; set; }
}