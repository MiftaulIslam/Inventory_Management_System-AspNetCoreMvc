﻿using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class SellingPaymentReturnRecord
{
    [Key]
    public int Id { get; set; }
    public decimal PrevReturnAmount { get; set; }
    public decimal CurrentReturnAmount { get; set; }
    public decimal NetReturnAmount { get; set; }
    public int? AccountId { get; set; }
    public Account Account { get; set; }
    public DateTime InsertDateUtc { get; set; }
    public int SellingId { get; set; }
    public Selling Selling { get; set; }
    public int RegistrationId { get; set; }
    public Registration Registration { get; set; }
}