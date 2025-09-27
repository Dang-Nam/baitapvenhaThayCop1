using System;
using MathDLL;  // Namespace của DLL

namespace ConsoleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập 3 chữ số (0-9):");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a < 0 || a > 9 || b < 0 || b > 9 || c < 0 || c > 9)
            {
                Console.WriteLine("Chỉ nhập chữ số 0-9!");
                return;
            }

            Calculator calc = new Calculator();
            calc.NumA = a;
            calc.NumB = b;
            calc.NumC = c;
            calc.Calculate();

            Console.WriteLine(calc.Message);  
            Console.ReadKey();
        }
    }
}