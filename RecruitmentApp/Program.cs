using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
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

        public static class DbToJsonString
        {
            public static string Convert(RecruitmentDbContext _context)
            {
                List<Product> data = _context.Products.Select(x => x).ToList();
                string json = JsonSerializer.Serialize(data);
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

        public static class UpdateDbFromJsonFile
        {
            public static Log? Update(string filePath, RecruitmentDbContext _context)
            {
                string json = File.ReadAllText(filePath);
                List<Product>? products = JsonSerializer.Deserialize<List<Product>>(json);

                Log log = new Log();

                foreach(Product product in products)
                {
                    // Check if record with specified id exists
                    var result = _context.Products.SingleOrDefault(x => x.Id == product.Id);
                    if (result != null)
                    {
                        log.type = "Update";
                        log.original = result;
                        log.updated = product;
                        log.time = DateTime.Now.ToString();

                        // If record exists then update it
                        result.ProductName = product.ProductName;
                        result.ProductPrice = product.ProductPrice;
                        result.ProductCategory = product.ProductCategory;
                        result.AddDate = product.AddDate;
                        result.EditDate = product.EditDate;
                        result.DeleteDate = product.DeleteDate;
                        _context.SaveChanges();
                    }
                    else
                    {
                        log.type = "Insert";
                        log.original = null;
                        log.updated = product;
                        log.time = DateTime.Now.ToString();

                        // If record not exist add it
                        _context.Products.Add(product);
                        _context.SaveChanges();
                    }
                    return log;
                }
                return null;
            }
        }

        public class Log
        {
            public string time { get; set; }
            public string type { get; set; }
            public Product? original { get; set; }
            public Product updated { get; set; }
        }

        public static class SaveLogToFile
        {
            public static void Save(string filePath, Log log)
            {
                string json = JsonSerializer.Serialize(log);

                using (FileStream fs = new FileStream(filePath, FileMode.Append))
                {
                    fs.Write(new UTF8Encoding(true, true).GetBytes(json));
                }
            }
        }
    }
}