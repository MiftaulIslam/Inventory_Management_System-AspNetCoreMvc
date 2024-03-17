using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class Account
{


    [Key]
    public int Id { get; set; }
    public string AccountName { get; set; }
    public decimal Balance { get; set; }
    public decimal CostPercentage { get; set; }
    public int InstitutionId {get;set;}
    public Institution Institution { get; set; }
    public virtual ICollection<AccountWithdraw> AccountWithdraw { get; set; }
    public virtual ICollection<AccountDeposit> AccountDeposit { get; set; }
    public virtual ICollection<SellingPayment> SellingPayment { get; set; }
    public virtual ICollection<PurchasePayment> PurchasePayment { get; set; }
    public virtual ICollection<Expense> Expense { get; set; }
    public virtual ICollection<ExpenseTransportation> ExpenseTransportation { get; set; }
    public virtual ICollection<SellingPaymentReturnRecord> SellingPaymentReturnRecord { get; set; }
    public virtual ICollection<SellingExpense> SellingExpense { get; set; }
    public virtual ICollection<PurchasePaymentReturnRecord> PurchasePaymentReturnRecord { get; set; }
}