using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Text.Json;

namespace RecruitmentApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main_window(new RecruitmentDbContext()));
        }

        public class Startup
        {
            public void ConfigureServices(IServiceCollection services)
            {
                // Replace with your connection string.
                var connectionString = "Server=localhost;User=root;Password=;Database=recruitment_db";

                // Replace with your server version and type.
                // Use 'MariaDbServerVersion' for MariaDB.
                // Alternatively, use 'ServerVersion.AutoDetect(connectionString)'.
                // For common usages, see pull request #1233.
                var serverVersion = new MySqlServerVersion(new Version(10, 4, 27));

                // Replace 'YourDbContext' with the name of your own DbContext derived class.
                services.AddDbContext<RecruitmentDbContext>(
                    dbContextOptions => dbContextOptions
                        .UseMySql(connectionString, serverVersion)
                );
            }
        }

        public static class DbToJsonString
        {
            public static string Convert(RecruitmentDbContext _context)
            {
                var data = _context.Products.Select(x => x).ToList();
                var json = JsonSerializer.Serialize(data);
                return json;
            }
        }

        public static class SaveJsonToFile
        {
            public static void Save(string json, string filePath)
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    fs.Write(new UTF8Encoding(true, true).GetBytes(json));
                }
            }
        }
    }
}