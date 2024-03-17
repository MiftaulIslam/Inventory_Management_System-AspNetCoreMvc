using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class ExpenseTransportation
{
    public ExpenseTransportation()
    {
        ExpenseTransportationList = new HashSet<ExpenseTransportationList>();
    }
    [Key]
    public int Id { get; set; }
    public int? CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
    public int VoucherNo { get; set; }
    public bool IsApproved { get; set; }
    public int RegistrationId { get; set; }
    public virtual Registration Registration { get; set; }
    public decimal TotalExpense { get; set; }
    public string ExpenseNote { get; set; }
    public DateTime ExpenseDate { get; set; }
    public DateTime InsertDate { get; set; }
    public int? AccountId { get; set; }
    public Account Account { get; set; }
    public virtual ICollection<ExpenseTransportationList> ExpenseTransportationList { get; set; }
}