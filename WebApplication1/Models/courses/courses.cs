using YourNamespace;

public class Course
{
    public int Id { get; set; }
    public required string CourseName { get; set; }
}

public class YourDbContext : DbContext
{
    public required DbSet<Course> Courses { get; set; }
}

public class DbSet<T>
{
    internal string? ToList()
    {
        throw new NotImplementedException();
    }
}

public class DbContext
{
}

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


