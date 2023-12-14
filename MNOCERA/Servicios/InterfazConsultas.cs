using MNOCERA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOCERA.Servicios
{
    public interface InterfazConsultas
    {
        /// <summary>
        /// Método para dar de alta elementos de Vajilla
        /// </summary>
        public void DarAltaElemento();
        /// <summary>
        /// Método para mostrar todo el stock
        /// </summary>
        public void MostrarStock();


    }
}

