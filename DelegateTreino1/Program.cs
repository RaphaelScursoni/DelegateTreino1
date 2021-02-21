using DelegateTreino1.Services;
using System;

namespace DelegateTreino1 {

    delegate double BinaryNumericOpetation(double n1, double n2);
    
    class Program {
        static void Main(string[] args) {

            double a = 10;
            double b = 12;

            BinaryNumericOpetation op = CalculationService.Sum;

            double result = op(a, b);
            Console.WriteLine(result);


        }
    }
}
