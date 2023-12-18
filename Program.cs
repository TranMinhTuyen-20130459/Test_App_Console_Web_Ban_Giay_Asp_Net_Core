using System.Diagnostics;
using Test_App_Console.Data;
using Web_Ban_Giay_Asp_Net_Core.Entities.Config;

namespace Test_App_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            MyDbContext dbContext = new MyDbContext();

            try
            {
                DataUtils.AddDataToTable_First(dbContext);
                DataUtils.AddDataToTable_Second(dbContext);
                DataUtils.AddDataToTable_Three(dbContext);
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
