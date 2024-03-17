using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public partial class PageLinkCategory
{
    public PageLinkCategory()
    {
        PageLink = new HashSet<PageLink>();
    }

[Key]
    public int Id { get; set; }
    public string Category { get; set; }
    public string IconClass { get; set; }
    public int? Sn { get; set; }
    public virtual ICollection<PageLink> PageLink { get; set; }
}
