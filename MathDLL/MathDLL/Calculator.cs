using System;

namespace MathDLL
{
    public class Calculator
    {
        // Input properties
        public int NumA { get; set; }
        public int NumB { get; set; }
        public int NumC { get; set; }

        // Output properties
        public int Sum { get; private set; }
        public string Message { get; private set; }

        public void Calculate()
        {
            Sum = NumA + NumB + NumC;
            string parity = (Sum % 2 == 0) ? "chẵn" : "lẻ";
            Message = "Kết quả từ Nam : Tổng là " + Sum + ", và nó " + parity + " như cuộc đời!"; 
        }
    }
}