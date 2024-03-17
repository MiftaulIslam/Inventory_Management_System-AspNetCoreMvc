using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class AccountWithdraw
{
    [Key]
    public int Id { get; set; }
    public int AccountId { get; set; }
    public Account Account { get; set; }
    public decimal WithdrawAmount { get; set; }
    public string Description { get; set; }
    public DateTime WithdrawDateUtc { get; set; }
    public DateTime InsertDateUtc { get; set; }
}