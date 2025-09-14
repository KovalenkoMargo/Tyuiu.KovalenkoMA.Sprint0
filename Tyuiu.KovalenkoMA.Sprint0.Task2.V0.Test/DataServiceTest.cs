using Tyuiu.KovalenkoMA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KovalenkoMA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Margo";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Hello, Margo", res);
        }
    }
}
