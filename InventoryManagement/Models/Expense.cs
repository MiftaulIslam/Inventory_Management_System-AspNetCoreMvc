using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class Expense
{
    [Key]
    public int Id { get; set; }
    public int VoucherNo { get; set; }
    public bool IsApproved { get; set; }
    public int RegistrationId { get; set; }
    public virtual Registration Registration { get; set; }
    public int ExpenseCategoryId { get; set; }
    public virtual ExpenseCategory ExpenseCategory { get; set; }
    public decimal ExpenseAmount { get; set; }
    public string ExpenseFor { get; set; }
    public DateTime ExpenseDate { get; set; }
    public DateTime InsertDate { get; set; }
    public int? AccountId { get; set; }
    public Account Account { get; set; }
}
