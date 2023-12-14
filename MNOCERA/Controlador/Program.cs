
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using MNOCERA.Servicios;

class Program
{
    public static void Main()
    {
        InterfazInicio interfazInicio = new ImplementacionInicio();
        InterfazConsultas interfazConsultas=new ImplementacionConsultas();
        int opcion = 0;
        do
        {
            opcion = interfazInicio.Menu();
            switch ( opcion )
            {
                case 1:
                    interfazConsultas.DarAltaElemento();
                    break;
                case 2:
                    interfazConsultas.MostrarStock();
                    break;   
            }
        } while (opcion!=0);
    }
}
