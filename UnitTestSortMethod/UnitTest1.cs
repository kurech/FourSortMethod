using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FourSortMethod;

namespace UnitTestSortMethod
{
    [TestClass]
    public class UnitTest1
    {
        MainWindow mainWindow = new MainWindow();

        [TestMethod]
        public void BubbleMethod()
        {
            int[] _startmassive = new int[] { 54, -90, -1, 0, 18};

            int[] expected = new int[] { -90, -1, 0, 18, 54 };

            int[] result = mainWindow.BubbleSort(_startmassive);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InsertMethod()
        {
            int[] _startmassive = new int[] { 54, -90, -1, 0, 18 };

            int[] expected = new int[] { -90, -1, 0, 18, 54 };

            int[] result = mainWindow.InsertionSort(_startmassive);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChoseMethod()
        {
            int[] _startmassive = new int[] { 54, -90, -1, 0, 18 };

            int[] expected = new int[] { -90, -1, 0, 18, 54 };

            int[] result = mainWindow.ViborSort(_startmassive);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShellMethod()
        {
            int[] _startmassive = new int[] { 54, -90, -1, 0, 18 };

            int[] expected = new int[] { -90, -1, 0, 18, 54 };

            int[] result = mainWindow.ShellSort(_startmassive);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
