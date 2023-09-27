using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace YourNamespace
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.using Microsoft.Extensions.DependencyInjection;services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

      services.AddMvc();
    }

        private void AddDbContext<T>(Func<object, object> value)
        {
            throw new NotImplementedException();
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

  internal class ApplicationDbConpublic private DbSet<Product>? Products { get; set; }public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
  {
      Product = new DbSet<Product>();
  }

    public class ApplicationDbContext
    {
    }

    text : DbContext
  {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public public DbSet<Product>? Products { get; set; }

        public DbSet<Product> Products { get; set; }
  }

    public class Product
    {
    }

    public class DbSet<T>
    {
    }

    public class DbContextOptions<T>
    {
    }

    internal class DbContext
    {
        private DbContextOptions<ApplicationDbContext> options;

        public DbContext(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }
    }
}


