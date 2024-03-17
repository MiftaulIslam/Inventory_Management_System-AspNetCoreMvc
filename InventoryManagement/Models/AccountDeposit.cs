using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class AccountDeposit
{
    [Key]
    public int Id { get; set; }
    public int AccountId { get; set; }
    public Account Account { get; set; }
    public decimal DepositAmount { get; set; }
    public string Description { get; set; }
    public DateTime DepositDateUtc { get; set; }
    public DateTime InsertDateUtc { get; set; }
}