namespace A4_EF_CRUD_Validation.Models;

public class CourseViewModel
{
    ////////////////
    // Properties //
    ////////////////

    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Instructor { get; set; }
    public int? Credits { get; set; }
    public bool? Online { get; set; }

    /////////////////
    // Constructor //
    /////////////////
}
