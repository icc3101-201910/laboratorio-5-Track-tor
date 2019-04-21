using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5
{
    class Calculadora
    {
        private int numero;
        public ICalcular[] operaciones;

        public Calculadora(int numero)
        {
            this.numero = numero;
            operaciones = new ICalcular[5] { new PersonaQueSuma5(), new PerroFactorial(), new RobotFibonacci(), new Cubo(), new Cuadrado()};
        }

        public void Calcular(int opcion)
        {
            if (opcion == 0)
            {
                Console.WriteLine("Sumando 5 al numero {0}..",numero);
                numero = operaciones[0].Calcular(numero);
                
            }
            else if (opcion == 1)
            {
                Console.WriteLine("Obteniendo el factorial del numero {0}...", numero);
                numero = operaciones[1].Calcular(numero);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Obteniendo el fibonacci del numero {0}...", numero);
                numero = operaciones[2].Calcular(numero);
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Obteniendo el cubo del numero {0}...", numero);
                numero = operaciones[3].Calcular(numero);
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Obteniendo el cuadrado del numero {0}...", numero);
                numero = operaciones[4].Calcular(numero);
            }

        }
        public int GetNumero()
        {
            return numero;
        } 
    }
}
