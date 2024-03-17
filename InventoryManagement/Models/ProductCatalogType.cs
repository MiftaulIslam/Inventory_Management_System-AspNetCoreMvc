using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public partial class ProductCatalogType
{
     [Key]
      public int Id { get; set; } 
[Required] 
public string CatalogType { get; set; } 
public DateTime InsertDate { get; set; } 
public DateTime? UpdatedAt { get; set; } 
public virtual ICollection<ProductCatalog>? ProductCatalog { get; set; } }
