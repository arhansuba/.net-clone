
using YourNamespace;

public class Course
{
    public int Id { get; set; }
    public required string CourseName { get; set; }
    
}
// CourseController.cs
public class CourseController : Microsoft.AspNetCore.Mvc.Controller
{
    private readonly YourDbContext _dbContext;

    public CourseController(YourDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Microsoft.AspNetCore.Mvc.IActionResult Index()
    {
        var courses = _dbContext.Courses.ToList();
        return View(courses);
    }
}

