using Tyuiu.KovalenkoMA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KovalenkoMA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {

            var name = "Margo";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Hello, Margo", res);
        }
    }
}
