using DogWalkingBusiness.Applications.Interfaces;
using DogWalkingBusiness.Applications.Services;
using DogWalkingBusiness.Infrastructure.Data;
using DogWalkingBusiness.WinFormsUI.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DogWalkingBusiness
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            using (var scope = ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<DogWalkingDbContext>();
                context.Database.Migrate();
                DbInitializer.Seed(context);
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new WinFormsUI.Views.LoginForm());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DogWalkingDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddAutoMapper(typeof(MappingProfile).Assembly);

            //services.AddScoped<IClientService, ClientService>();
            //services.AddScoped<IDogService, DogService>();
            //services.AddScoped<IWalkService, WalkService>();

            services.AddScoped<LoginForm>();
            services.AddScoped<MainForm>();
            services.AddScoped<ClientForm>();
            services.AddScoped<DogForm>();
            services.AddScoped<WalkForm>();           
        }

        private static IConfiguration Configuration =>
            new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();
    }
}
