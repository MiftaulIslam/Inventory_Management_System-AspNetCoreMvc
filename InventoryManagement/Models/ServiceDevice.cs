using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public partial class ServiceDevice
{
    public ServiceDevice()
    {
        ServiceList = new HashSet<ServiceList>();
    }
[Key]
    public int Id { get; set; }
    public int ProductCatalogId { get; set; }
    public int CustomerId { get; set; }
    public string DeviceCode { get; set; }
    public string DeviceName { get; set; }
    public string Description { get; set; }
    public DateTime InsertDate { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual ProductCatalog ProductCatalog { get; set; }
    public virtual ICollection<ServiceList> ServiceList { get; set; }
}
