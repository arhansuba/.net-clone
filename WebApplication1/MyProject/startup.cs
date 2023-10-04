using Microsoft.EntityFrameWorkCore;

internal class YourDbContext : DbContext
{
    public YourDbContext()
    {
        Courses = new List<Course>(); 
    }

    public required object Courses { get; set; }

    internal string? Courses => Courses.Select(c => c.CourseName).ToList();
}

namespace YourNamespace
{
    public class Startup
    {
        private IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<YourDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        
            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }

    internal class YourDbContext : DbContext
{
    public YourDbContext()
    {
        Courses = new List<Course>(); 
    }

    public required object Courses { get;  set; }

        

}
}
