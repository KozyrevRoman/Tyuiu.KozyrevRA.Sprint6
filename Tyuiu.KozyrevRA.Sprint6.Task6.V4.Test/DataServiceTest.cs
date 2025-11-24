using Tyuiu.KozyrevRA.Sprint6.Task6.V4.Lib;
namespace Tyuiu.KozyrevRA.Sprint6.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\GIGABYTE\Desktop\DataSprint5\InPutDataFileTask6V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void ValidCalculation()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\GIGABYTE\Desktop\DataSprint5\InPutDataFileTask6V4.txt";
            var res = ds.CollectTextFromFile(path);
            string wait = "SnBCOoyPFhjSRwp\nnnndrMRbvnKtNW";
            Assert.AreEqual(wait, res);
        }
    }
}
