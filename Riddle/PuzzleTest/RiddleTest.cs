using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Riddle
{

    [TestClass]
    public class RiddleTest
    {
        [TestMethod]
        public void TextBackSubTest()
        {
            // arrange
            MainWindow objMainWindow = new MainWindow();
            string[] substr= { "farmer", "goat" };

            string expected = "\nfarmer\ngoat";
            // act
            objMainWindow.TextBackSub(substr);
            string actual = MainWindow.stringThereView.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TextThereSubTest()
        {
            // arrange
            MainWindow objMainWindow = new MainWindow();
            string[] substr = { "farmer" };

            string expected = "";
            // act
            objMainWindow.TextThereSub(substr);
            string actual = MainWindow.stringThereView.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
