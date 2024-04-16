using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public partial class Purchase
{

[Key]
    public int Id { get; set; }
    public int VendorId { get; set; }
    public int PurchaseSn { get; set; }
    public decimal PurchaseTotalPrice { get; set; }
    public decimal PurchaseDiscountAmount { get; set; }
    public decimal PurchaseDiscountPercentage { get; set; }
    public decimal PurchasePaidAmount { get; set; }
    public decimal PurchaseReturnAmount { get; set; }
    public decimal PurchaseDueAmount { get; set; }
    public string PurchasePaymentStatus { get; set; }
    public string MemoNumber { get; set; }
    public DateTime PurchaseDate { get; set; }
    public DateTime UpdateAt { get; set; }
    public virtual Vendor Vendor { get; set; }
    public virtual Selling Selling { get; set; }
    public virtual ICollection<PurchaseList> PurchaseList { get; set; }
    public virtual ICollection<PurchasePaymentList> PurchasePaymentList { get; set; }
    public virtual ICollection<ProductLog> ProductLog { get; set; }
    public virtual ICollection<PurchasePaymentReturnRecord> PurchasePaymentReturnRecord { get; set; }
}
