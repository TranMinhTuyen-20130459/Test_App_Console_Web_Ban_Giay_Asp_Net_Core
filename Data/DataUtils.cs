using Web_Ban_Giay_Asp_Net_Core.Data.Class;
using Web_Ban_Giay_Asp_Net_Core.Entities.Config;

namespace Test_App_Console.Data
{
    public static class DataUtils
    {
        public static void AddDataToTable_First(MyDbContext dbContext)
        {

            /* new DataUser().AddDataToTable(dbContext);

             new DataAdmin().AddDataToTable(dbContext);

             new DataTypeProduct().AddDataToTable(dbContext);

             new DataBrand().AddDataToTable(dbContext);

             new DataSize().AddDataToTable(dbContext);

             new DataPriceRange().AddDataToTable(dbContext);
 */
            new DataOrder().AddDataToTable(dbContext);

        }

        public static void AddDataToTable_Second(MyDbContext dbContext)
        {
            new DataProductShoes().AddDataToTable(dbContext);

            new DataImageProductShoes().AddDataToTable(dbContext);

        }

        public static void AddDataToTable_Three(MyDbContext dbContext)
        {
            // new DataProductSportsWear().AddDataToTable(dbContext);

            // new DataImageProductSportsWear().AddDataToTable(dbContext);

            new DataSizeProduct().AddDataToTable(dbContext);

            new DataHistoryPriceProduct().AddDataToTable(dbContext);

            //new DataOrderDetail().AddDataToTable(dbContext);
        }
    }
}
