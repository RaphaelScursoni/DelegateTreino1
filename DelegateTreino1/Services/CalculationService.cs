using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTreino1.Services {
    class CalculationService {
        public static double Max(double x, double y) {
            return (x > y) ? x : y;
        } // MAIOR
        public static double Sum(double x, double y) {
            return x + y;
        } // SOMA
        public static double Square(double x) {
            return x * x;
        } // QUADRADO 
    }
}