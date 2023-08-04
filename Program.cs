using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Web_Ban_Giay_Asp_Net_Core.Data.Class;
using Web_Ban_Giay_Asp_Net_Core.Entities.Config;

namespace Test_App_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo ILoggerFactory và cấu hình logging cho nó bằng LoggerFactory
            ILoggerFactory loggerFactory = CreateLoggerFactory();

            // Tạo IServiceProvider và đăng ký các dịch vụ cần thiết
            var serviceProvider = ConfigureServices(loggerFactory);

            // Lấy ra MyDbContext từ IServiceProvider
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<MyDbContext>();

                //new DataBrand().AddDataToTable(dbContext);
                //new DataTypeProduct().AddDataToTable(dbContext);

                //new DataSize().AddDataToTable(dbContext);
                //new DataPriceRange().AddDataToTable(dbContext);

                //new DataProduct().AddDataToTable(dbContext);

                //DataUtil.PrintArrayList(DataUtil.GetListIdProduct(dbContext));

                //DataUtil.PrintArrayList(DataUtil.GetListNameSize(dbContext));

                //new DataImageProduct().AddDataToTable(dbContext);

                new DataSizeProduct().AddDataToTable(dbContext);

            }

            Console.ReadKey();
        }

        // Phương thức để tạo và cấu hình ILoggerFactory
        private static ILoggerFactory CreateLoggerFactory()
        {
            return LoggerFactory.Create(builder =>
            {
                builder
                    .AddConsole() // Thêm provider cho logging console
                    .SetMinimumLevel(LogLevel.Information); // Thiết lập mức log tối thiểu
            });
        }

        // Phương thức để đăng ký các dịch vụ cần thiết
        private static IServiceProvider ConfigureServices(ILoggerFactory loggerFactory)
        {
            var services = new ServiceCollection();

            // Đăng ký ILoggerFactory vào DI container
            services.AddSingleton(loggerFactory);

            // Đăng ký DbContextOptions và ILoggerFactory
            services.AddDbContext<MyDbContext>(options =>
            {
                string connectionString = "Server=127.0.0.1;Database=asp_net_core_web_ban_giay;User=root;Password=;";
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

                // Lấy ILoggerFactory từ ServiceProvider để thêm logging cho EF Core
                options.UseLoggerFactory(loggerFactory);
            });

            // Build và trả về IServiceProvider
            return services.BuildServiceProvider();
        }
    }
}
