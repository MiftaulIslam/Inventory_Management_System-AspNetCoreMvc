using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class ExpenseFixed
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public int IntervalDays { get; set; }
    public decimal CostPerDay { get; set; }
    public DateTime InsertDate { get; set; }
}