using System;
using System.Collections.Generic;

namespace MNOCERA.Models;
/// <summary>
/// Entidad que representa los elementos de una Vajilla
/// </summary>
public partial class Vajilla
{
    public int Idelemento { get; set; }

    public int? Cantidadelemento { get; set; }

    public string? Codigoelemento { get; set; }

    public string? Descripcionelemento { get; set; }

    public string? Nombreelemento { get; set; }

    public Vajilla(int? cantidadelemento, string? codigoelemento, string? descripcionelemento, string? nombreelemento)
    {
        Cantidadelemento = cantidadelemento;
        Codigoelemento = codigoelemento;
        Descripcionelemento = descripcionelemento;
        Nombreelemento = nombreelemento;
    }
    /// <summary>
    /// Método para mostrar en un string un elemento de Vajilla
    /// </summary>
    /// <returns></returns>
    public string stringElemento()
    {
        return "[idElemento="+Idelemento+";codigoElemento="+Codigoelemento+";nombreElemento="+Nombreelemento+
            ";cantidadElemento="+Cantidadelemento+"]";
    }
}
