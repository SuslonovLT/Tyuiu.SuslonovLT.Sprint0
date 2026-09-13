using Tyuiu.SuslonovLT.Sprint0.Task2.V0.Lib;
namespace Tyuiu.SuslonovLT.Sprint0.Task2.V0.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Леонид";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Леонид", res);
        }
    }
}
