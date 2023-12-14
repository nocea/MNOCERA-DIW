using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOCERA.Servicios
{
    internal class ImplementacionInicio : InterfazInicio
    {
        public int Menu()
        {
            int opcion = 0;
            
                do
                {
                    Console.WriteLine("Introduzca una opción del menú:");
                    Console.WriteLine("1.Alta Elemento");
                    Console.WriteLine("2.Mostrar Stock");
                    Console.WriteLine("3.Reservar(no terminado)");
                    Console.WriteLine("0.Salir");
                    opcion = int.Parse(Console.ReadLine());
                    if (opcion < 0 || opcion > 3)
                    {
                        Console.Clear();
                        Console.WriteLine("[ERROR]-ESA OPCIÓN NO ESTÁ EN EL MENÚ]");
                    }
                } while (opcion < 0 || opcion > 3);
                Console.Clear();
            return opcion;
        }
    }
}
