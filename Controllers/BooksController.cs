using Microsoft.AspNetCore.Mvc;

namespace A4_EF_CRUD_Validation.Controllers;

public class BooksController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
