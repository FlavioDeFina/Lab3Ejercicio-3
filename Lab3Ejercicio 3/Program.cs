using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la cantidad de adivinanzas: ");
            int adivinanzas = int.Parse(Console.ReadLine());

            float pago = 0f;

            if (edad >= 18) 
            {
                if (adivinanzas < 3) 
                {
                    pago = 30 + 5 * edad + 2 * adivinanzas;
                }
                else 
                {
                    pago = 50 + 5 * edad + 2 * adivinanzas;
                }
                Console.WriteLine("El monto final que recibe el participante es de: "+pago);    
            }
            else 
            {
                if (adivinanzas < 3)
                {
                    pago = 50 + 5 * edad + 2 * adivinanzas;
                }
                else
                {
                    pago = 80 + 5 * edad + 2 * adivinanzas;
                }
                Console.WriteLine("El monto final que recibe el participante es de: " + pago);
            }
            Console.ReadKey();
        }
    }
}
