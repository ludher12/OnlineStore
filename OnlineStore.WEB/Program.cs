using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Application.Interfaces;
using OnlineStore.Application.Mappings;
using OnlineStore.Infrastructure.Repositories;

namespace OnlineStore.WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            

            builder.Services.AddDbContext<OnlineStore.Infrastructure.Persistence.OnlineStoeDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            //AutoMApper
            builder.Services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<ProductProfile>();
            });

            //Mediatr
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<OnlineStore.Application.AssemblyMarker>());

            // Repositories
            builder.Services.AddScoped<ICursosRepository, CursoRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
