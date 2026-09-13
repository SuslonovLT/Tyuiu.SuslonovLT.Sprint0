using Tyuiu.SuslonovLT.Sprint0.Task3.V0.Lib;
namespace Tyuiu.SuslonovLT.Sprint0.Task3.V0.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
