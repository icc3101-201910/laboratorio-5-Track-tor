using System;

namespace Laboratorio_5
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int num;

                Console.WriteLine("\nIngrese un numero");
                num = Convert.ToInt32(Console.ReadLine());//num se utiliza para definir el numero a operar


                Calculadora calculadora = new Calculadora(num); // se defina la calculadora con el numero ingresado por el usuario
                Console.WriteLine("\nIngrese que operacion desea hacer sobre el numero {0}:",calculadora.GetNumero());
                Console.WriteLine("[0]: Sumar 5\n[1]: Obtener Factorial\n[2]: Obtener Fibonacci\n[3]: Elevar al cubo\n[4]: Elevar al cuadrado\n[5]: Salir\n");
                num = Convert.ToInt32(Console.ReadLine());
                //num se utiliza como la opcion
                if (num == 5)// opcion para salir del loop
                {
                    Console.WriteLine("Saliendo del programa");
                    break;
                }

                calculadora.Calcular(num);//opcion que se ejecuta
                Console.WriteLine("\nel resultado es: {0}", calculadora.GetNumero());

            }

        }
    }
}
