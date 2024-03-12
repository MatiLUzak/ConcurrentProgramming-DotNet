using ProjektWsp;
using System.Windows.Controls;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [STAThread]
        public void TestMethod1()
        {
            var mainWindow = new ProjektWsp.MainWindow();
            mainWindow.Show();
            var block = mainWindow.FindName("TextBlock1") as TextBlock;
            Assert.AreEqual("Test", block.Text);
            mainWindow.Close();
        }
    }
}