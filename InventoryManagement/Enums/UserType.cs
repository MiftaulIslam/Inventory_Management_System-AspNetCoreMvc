using System.ComponentModel;

namespace InventoryManagement.Enums;

public enum UserType
{
    [Description("Admin")] Admin,
    [Description("SubAdmin")] SubAdmin,
    [Description("SalesPerson")] SalesPerson
}