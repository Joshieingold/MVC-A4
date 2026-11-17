using A4_EF_CRUD_Validation.Models;
using DbDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace A4_EF_CRUD_Validation.Controllers;

public class CourseController : Controller
{
    public readonly CourseDbContext _service;

    public CourseController(CourseDbContext cdc)
    {
        _service = cdc;
    }

    public IActionResult Index()
    {
        return RedirectToAction("Show", "Course");
    }

    public IActionResult Show()
    {
        var items = _service.Course.OrderBy(m => m.Id).ToList();
        return View(items);
    }

    [HttpGet]
    public IActionResult Create()
    {
        Course c = new();
        return View(c);
    }

    [HttpPost, ActionName("Create")]
    public IActionResult CreatePost(Course c)
    {
        if (!ModelState.IsValid)
        {
            return View(c);
        }
        _service.Add(c);
        _service.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        Course c = _service.Course.FirstOrDefault(c => c.Id == id);
        return View(c);
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
