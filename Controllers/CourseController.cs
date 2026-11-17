using A4_EF_CRUD_Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace A4_EF_CRUD_Validation.Controllers;

public class CourseController : Controller
{
    private readonly CourseDbContext _service;

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
        List<Course> items = _service.Course.OrderBy(m => m.Id).ToList();
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
        Course? foundCourse = _service.Course.FirstOrDefault(c => c.Id == id);
        if (foundCourse == null)
        {
            return NotFound();
        }
        return View(foundCourse);
    }

    [HttpPost, ActionName("Edit")]
    public IActionResult EditPost(Course updatedCourse)
    {
        // Make sure the model is valid
        if (!ModelState.IsValid)
        {
            return View(updatedCourse);
        }
        Course? foundCourse = _service.Course.Find(updatedCourse.Id);
        // Make sure we found one
        if (foundCourse == null)
        {
            return NotFound();
        }
        // Update
        foundCourse.Instructor = updatedCourse.Instructor;
        foundCourse.Title = updatedCourse.Title;
        foundCourse.Credits = updatedCourse.Credits;
        foundCourse.Online = updatedCourse.Online;
        // Save
        _service.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        Course? foundCourse = _service.Course.FirstOrDefault(c => c.Id == id);
        if (foundCourse == null)
        {
            return NotFound();
        }
        return View(foundCourse);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int id)
    {
        Course? foundCourse = _service.Course.Find(id);
        if (foundCourse == null)
        {
            return NotFound();
        }
        _service.Course.Remove(foundCourse);
        _service.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}
