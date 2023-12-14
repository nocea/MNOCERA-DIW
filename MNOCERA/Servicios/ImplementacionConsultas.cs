using MNOCERA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOCERA.Servicios
{
    public class ImplementacionConsultas: InterfazConsultas
    {
        private readonly ExaDosContext contexto=new ExaDosContext();

        public void DarAltaElemento()
        {
            try
            {
                int cantidad;
                string nombre, descripcion, codigo;
                //Pido los datos
                Console.Write("\nIntroduzca el nombre del elemento: ");
                nombre = Console.ReadLine();
                Console.Write("\nIntroduzca la descripcion del elemento: ");
                descripcion = Console.ReadLine();
                Console.Write("\nIntroduzca la cantidad del elemento: ");
                cantidad = int.Parse(Console.ReadLine());
                codigo = "Elem-"+nombre;
                //Creo el elemento
                Vajilla elemento = new Vajilla(cantidad, codigo, descripcion, nombre);
                //Lo añado y guardo los cambios
                contexto.Vajillas.Add(elemento);
                contexto.SaveChanges();
                Console.Clear();
                Console.WriteLine("[INFO]-Se ha dado de alta el elemento");
            }catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine("[ERROR]-Se ha producido un error insertando el elemento");
            }
        }
        public void MostrarStock()
        {
            try { 
                //obtengo la lista de todos los elementos
            List<Vajilla> listaElementos = contexto.Vajillas.ToList();
                //Los muestro
            for (int i = 0; i < listaElementos.Count; i++)
            {
                Console.WriteLine(listaElementos[i].stringElemento());
            }
            Console.WriteLine("Pulse una tecla para volver al menú");
            Console.ReadKey();
            Console.Clear();
            }catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine("[ERROR]-Se ha producido un error mostrando los elementos");
            }
        }
    }
}
