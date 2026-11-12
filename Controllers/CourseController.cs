using Microsoft.AspNetCore.Mvc;

namespace A4_EF_CRUD_Validation.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Show()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost, ActionName("Create")]
    public IActionResult CreatePost()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Edit()
    {
        return View();
    }

    [HttpPost, ActionName("Edit")]
    public IActionResult EditPost()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Delete()
    {
        return View();
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost()
    {
        return View();
    }
}
