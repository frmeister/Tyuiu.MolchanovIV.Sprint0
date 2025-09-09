using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MolchanovIV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MolchanovIV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания тестирования методов, методов из библиотеки
            var name = "Игорь";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Игорь", res);
        }
    }
}
