using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}