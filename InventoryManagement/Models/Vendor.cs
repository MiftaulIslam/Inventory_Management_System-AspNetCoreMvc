using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public partial class Vendor
{
    public Vendor()
    {
        Purchase = new HashSet<Purchase>();
        PurchasePayment = new HashSet<PurchasePayment>();
    }
[Key]
    public int Id { get; set; }
    public string VendorCompanyName { get; set; }
    public string VendorName { get; set; }
    public string VendorAddress { get; set; }
    public string VendorPhone { get; set; }
    public string Description { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TotalDiscount { get; set; }
    public decimal ReturnAmount { get; set; }
    public decimal Paid { get; set; }
    public decimal Due { get; set; }
    public byte[] Photo { get; set; }
    public DateTime InsertDate { get; set; }
    public virtual ICollection<Purchase> Purchase { get; set; }
    public virtual ICollection<PurchasePayment> PurchasePayment { get; set; }
}
