using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MolchanovIV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MolchanovIV.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вызов класса DataService и метода GetMessage
            // из библиотеки Tyuiu.MolchanovIV.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Игорь"));

            Console.ReadKey();
        }
    }
}
