using Microsoft.EntityFrameworkCore;
using signalRD1Smart.Context;
using signalRD1Smart.Hubs;

namespace signalRD1Smart
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSignalR();
            builder.Services.AddSignalR(options =>
            {
                options.KeepAliveInterval = TimeSpan.FromSeconds(30); 
                options.ClientTimeoutInterval = TimeSpan.FromMinutes(1); 
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseWebSockets();


            app.UseRouting();

            app.UseAuthorization();

            // Add SignalR route
            app.MapHub<ChatHub>("/chatHub");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=chat}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
