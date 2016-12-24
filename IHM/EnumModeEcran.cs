using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHM
{
    [Flags]
    public enum EnumModeEcran
    {
        neutre = 1,
        ajout = 2,
        modification = 4,
        recherche = 8,
        priseRdv = 16
    }
}
