using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers;
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
