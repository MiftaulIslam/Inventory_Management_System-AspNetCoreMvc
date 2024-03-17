using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace InventoryManagement.Models;

public partial class ProductCatalog
{
[Key]
    public int Id { get; set; }
    public int? CatalogTypeId { get; set; }
    public string CatalogName { get; set; }
    public int CatalogLevel { get; set; }
    public int? ParentId { get; set; }
    public int ItemCount { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime UpdateAt { get; set; }
    public virtual ProductCatalogType CatalogType { get; set; } = default!;
    [JsonIgnore]
    public virtual ProductCatalog Parent { get; set; }= default!;
    [JsonIgnore]
    public virtual ICollection<ProductCatalog> InverseParent { get; set; }
    public virtual ICollection<Product> Product { get; set; }
    public virtual ICollection<ServiceDevice> ServiceDevice { get; set; }
    public virtual ICollection<Warranty> Warranty { get; set; }
}
