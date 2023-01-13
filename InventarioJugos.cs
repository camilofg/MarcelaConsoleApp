using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarcela
{
    public class InventarioJugos : IInventario
    {
        public bool InvDisponible(int unidInventario, int unidSolicitadas)
        {
            return unidInventario > unidSolicitadas;
        }
    }
}
