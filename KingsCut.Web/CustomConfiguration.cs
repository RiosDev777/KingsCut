using Microsoft.EntityFrameworkCore;
using KingsCut.Web.Data;
using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using KingsCut.Web.Services;

namespace KingsCut.Web
{
    public static class CustomConfiguration
    {
        public static WebApplicationBuilder AddCustomBuilderConfiguration(this WebApplicationBuilder builder)
        {
            // Data Context
            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection"));
            });

            // Toast Notification
            builder.Services.AddNotyf(config =>
            {
                config.DurationInSeconds = 10;
                config.IsDismissable = true;
                config.Position = NotyfPosition.BottomRight;
            });

            // Register services
            AddServices(builder);

            return builder;
        }

<<<<<<< HEAD
        public static void AddServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IProductsService, ProductService>();
=======
        public static void AddServices(WebApplicationBuilder builder) 
        { 

            builder.Services.AddScoped<IProductsService, ProductService>();
            builder.Services.AddScoped<IUsersServices, UserService>();
>>>>>>> Santiago
        }

        public static WebApplication AddCustomWebAppConfiguration(this WebApplication app)
        {
            app.UseNotyf();

            return app;
        }
    }
}

