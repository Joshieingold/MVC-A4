using System.ComponentModel.DataAnnotations;

namespace A4_EF_CRUD_Validation.Models;

public class Course
{
    ////////////////
    // Properties //
    ////////////////

    public int Id { get; set; }

    [Required(ErrorMessage = "Please Enter Course Title")]
    [StringLength(50, ErrorMessage = "Course Title cannot exceed 50 characters.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Please Enter the Name of the Instructor for the Course")]
    public string? Instructor { get; set; }

    [Range(0, 6)]
    public int? Credits { get; set; }
    public bool? Online { get; set; }

    /////////////////
    // Constructor //
    /////////////////
    public Course() { }
}
