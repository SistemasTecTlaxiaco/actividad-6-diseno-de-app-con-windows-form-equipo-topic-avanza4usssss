using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLibrary2
{
    public class Class1
    {
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public double Restar(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public  double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero");
            }

            return a / b;
        }

        public  double RaizCuadrada(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo");
            }

            return Math.Sqrt(a);
        }

        public  double Logaritmo(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("No se puede calcular el logaritmo de un número negativo");
            }

            return Math.Log10(a);
        }

        public  double Seno(double a)
        {
            double x = a * Math.PI / 180.0;
            double b = Math.Sin(x);
            return b;
        }

        public double Coseno(double a)
        {
            double x = a * Math.PI / 180.0;
            double b = Math.Cos(x);
            return b;
        }

        public double Tangente(double a)
        {
            double x = a * Math.PI / 180.0;
            double b = Math.Tan(x);
            return b;
        }
        public double factorial(double a)
        {
            int factorial = 0, total = 1;
            for (int i = 1; i <= factorial; i++)
            {
                total *= i;
            }
            return factorial;
        }
    }
}