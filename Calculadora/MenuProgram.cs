using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadoraa;
using OperacionesMatematicas;
namespace MenuCalculadora
{
    class MenuProgram
    {
        static void Main(string[] args)
        {
           CALCULADORA op = new CALCULADORA();
           Operaciones Calculadora = new Operaciones();
            double a, b, resultado;
            int opcion;
            Boolean valor=true;

            while(valor){
                Console.WriteLine("---------------Menu Caculadora---------------");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Raíz Cuadrada");
                Console.WriteLine("6. Logaritmo");
                Console.WriteLine("7. Seno");
                Console.WriteLine("8. Coseno");
                Console.WriteLine("9. Tangente");
                Console.WriteLine("10. Salir");
                Console.WriteLine();

                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el primer número: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        b = double.Parse(Console.ReadLine());
                        resultado = Calculadora.Sumar (a, b);
                        Console.WriteLine("El resultado de la suma es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("Ingrese el primer número: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        b = double.Parse(Console.ReadLine());
                        resultado = Calculadora.Restar(a, b);
                        Console.WriteLine("El resultado de la resta es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Ingrese el primer número: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        b = double.Parse(Console.ReadLine());
                        resultado = Calculadora.Multiplicar(a, b);
                        Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("Ingrese el primer número: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        b = double.Parse(Console.ReadLine());
                        resultado = Calculadora.Dividir(a, b);
                        Console.WriteLine("El resultado de la división es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Write("Ingrese un número: ");
                        a = double.Parse(Console.ReadLine());
                        resultado = Calculadora.RaizCuadrada(a);
                        Console.WriteLine("El resultado de la raíz cuadrada es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.Write("Ingrese un número: ");
                        a = double.Parse(Console.ReadLine());
                        resultado = Calculadora.Logaritmo(a);
                        Console.WriteLine("El resultado del logaritmo es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.Write("Ingrese un número: ");
                        a = double.Parse(Console.ReadLine());
                        resultado = Calculadora.Seno(a);
                        Console.WriteLine("El resultado del seno es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 8:
                        Console.Write("Ingrese un número: ");
                        a = double.Parse(Console.ReadLine());
                        resultado = Calculadora.Coseno(a);
                        Console.WriteLine("El resultado del coseno es: {0}", resultado);
                        Console.WriteLine();
                        break;

                     case 9:
                        Console.Write("Ingrese un número: ");
                        a = double.Parse(Console.ReadLine());
                        resultado = Calculadora.Tangente(a);
                        Console.WriteLine("El resultado de la tangente es: {0}", resultado);
                        Console.WriteLine();
                        break;
                    case 10:
                        Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
                        valor = false;
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion correcta.");
                        Console.WriteLine(); 
                        Console.ReadKey();
                        break;
                       
              }
            }
         }
    }
}