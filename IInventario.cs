using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarcela
{
    public interface IInventario
    {
        bool InvDisponible(int unidInventario, int unidSolicitadas);
    }
}
