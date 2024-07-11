using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal interface IArchivos
    {
        bool Guardar(List<Barco> barcos, string ruta);
        List<Barco> Leer(string ruta);
    }
}
