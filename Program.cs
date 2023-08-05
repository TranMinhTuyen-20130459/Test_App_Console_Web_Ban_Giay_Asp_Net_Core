using System.Diagnostics;
using Web_Ban_Giay_Asp_Net_Core.Data.Class;
using Web_Ban_Giay_Asp_Net_Core.Data.Util;
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

                //AddDataToTable_First(dbContext);
                AddDataToTable_Second(dbContext);

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

        static void AddDataToTable_First(MyDbContext dbContext)
        {

            new DataTypeProduct().AddDataToTable(dbContext);

            new DataBrand().AddDataToTable(dbContext);

            new DataSize().AddDataToTable(dbContext);

            new DataPriceRange().AddDataToTable(dbContext);

            new DataOrder().AddDataToTable(dbContext);

        }

        static void AddDataToTable_Second(MyDbContext dbContext)
        {
            new DataProduct().AddDataToTable(dbContext);

            new DataImageProduct().AddDataToTable(dbContext);

            new DataSizeProduct().AddDataToTable(dbContext);

            new DataHistoryPriceProduct().AddDataToTable(dbContext);

            new DataOrderDetail().AddDataToTable(dbContext);
        }

        static void TestFunctionUtil(MyDbContext dbContext)
        {
            FunctionUtil.PrintArrayList(DataUtil.GetListIdProduct(dbContext));

            FunctionUtil.PrintArrayList(DataUtil.GetListNameSize(dbContext));


            FunctionUtil.PrintArrayList(DataUtil.GetListIdOrder(dbContext));

            FunctionUtil.PrintArrayList(
                FunctionUtil
                .GetListElementRandom(DataUtil.GetListIdProduct(dbContext), 3));
        }

    }
}
