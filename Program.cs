using System.Diagnostics;
using Web_Ban_Giay_Asp_Net_Core.Data.Class;
using Web_Ban_Giay_Asp_Net_Core.Entities.Config;

namespace Test_App_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            MyDbContext dbContext = new MyDbContext();

            try
            {
                //new DataBrand().AddDataToTable(dbContext);

                //new DataTypeProduct().AddDataToTable(dbContext);

                //new DataSize().AddDataToTable(dbContext);

                //new DataPriceRange().AddDataToTable(dbContext);

                new DataProduct().AddDataToTable(dbContext);

                //DataUtil.PrintArrayList(DataUtil.GetListIdProduct(dbContext));

                //DataUtil.PrintArrayList(DataUtil.GetListNameSize(dbContext));

                new DataImageProduct().AddDataToTable(dbContext);

                new DataSizeProduct().AddDataToTable(dbContext);

                new DataHistoryPriceProduct().AddDataToTable(dbContext);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbContext.Dispose();
            }

            watch.Stop();
            Console.WriteLine("Total time: " + watch.Elapsed.TotalMinutes + " minute");

            Console.ReadKey();
        }

    }
}
