using DelegateTreino1.Services;
using System;

namespace DelegateTreino1 {

    delegate void BinaryNumericOpetation(double n1, double n2);
    
    class Program {
        static void Main(string[] args) {

            double a = 10;
            double b = 12;

            BinaryNumericOpetation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op(a, b);


        }
    }
}
