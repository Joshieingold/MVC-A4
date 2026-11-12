using System.ComponentModel.DataAnnotations;

namespace A4_EF_CRUD_Validation.Models;

public class Course
{
    ////////////////
    // Properties //
    ////////////////

    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string? Title { get; set; }

    [Required]
    public string? Instructor { get; set; }

    [Range(0, 3)]
    public int? Credits { get; set; }
    public bool? Online { get; set; }

    /////////////////
    // Constructor //
    /////////////////
    Course() { }
}
