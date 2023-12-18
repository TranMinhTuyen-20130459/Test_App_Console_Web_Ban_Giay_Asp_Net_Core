using Web_Ban_Giay_Asp_Net_Core.Data.Util;
using Web_Ban_Giay_Asp_Net_Core.Entities;
using Web_Ban_Giay_Asp_Net_Core.Entities.Config;

namespace Test_App_Console.Test
{
    public static class TestUtils
    {
        static void TestFunctionUtil(MyDbContext dbContext)
        {
            //FunctionUtil.PrintArrayList(DataUtil.GetListIdProduct(dbContext));

            //FunctionUtil.PrintArrayList(DataUtil.GetListNameSize(dbContext));


            //FunctionUtil.PrintArrayList(DataUtil.GetListIdOrder(dbContext));

            //FunctionUtil.PrintArrayList(
            //    FunctionUtil
            //    .GetListElementRandom(DataUtil.GetListIdProduct(dbContext), 3));


            FunctionUtil.PrintArrayList(DataUtil.GetListIdProductByType(dbContext, (int)TypeProductEnum.GIAY));
            FunctionUtil.PrintArrayList(DataUtil.GetListIdProductByType(dbContext, (int)TypeProductEnum.DO_THE_THAO));
        }
    }
}
