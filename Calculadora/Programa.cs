using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperacionesMatematicas;
namespace Calculadora
{
    class Programa
    {
        static void Main(string[] args)
        {

        Operaciones op= new Operaciones();

        double Resultado_s = op.Sumar(8, 10);
        Console.WriteLine("El resultado de la suma es: " + Resultado_s);

        double Resultado_r = op.Restar(10, 5);
        Console.WriteLine("El resultado de la resta es: " + Resultado_r);

        double Resultado_M = op.Multiplicar(2, 10);
        Console.WriteLine("El resultado de la multiplicacion es: " + Resultado_M);

        double Resultado_D = op.Dividir(10, 5);
        Console.WriteLine("El resultado de la division es: " + Resultado_D);
        Console.ReadKey();
        
        double Resultado_Raiz =  op.RaizCuadrada(4);
        
         
                        Console.WriteLine("El resultado de la raíz cuadrada es: {0}", resultado);
                        Console.WriteLine();
        }
        }

    }
}
