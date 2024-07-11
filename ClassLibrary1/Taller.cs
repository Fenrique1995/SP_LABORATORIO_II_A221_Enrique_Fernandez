using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Taller
    {
        private List<Barco> listaBarcos;

        public Taller()
        {
            listaBarcos = new List<Barco>();
        }

        public List<Barco> ListaBarcos { get { return listaBarcos; } }

        public bool EncontrarBarco(Barco barco)
        {
            return listaBarcos.Any(b => b.CompararBarcos(barco));
        }

        public bool IngresarBarco(Barco barco)
        {
            if (!EncontrarBarco(barco))
            {
                listaBarcos.Add(barco);
                return true;
            }
            return false;
        }

        public bool Reparar(Taller otroTaller)
        {
            if (otroTaller == null)
                return false;

            foreach (var barco in otroTaller.ListaBarcos)
            {
                if (!barco.EstadoReparado)
                {
                    try
                    {
                        barco.CalcularCostos(5000, 1000);
                        AccesoDatos.GuardarReparacion($"Se reparó el {barco.Nombre} a un costo de {barco.Costo} berries", "NombreAlumno");
                        barco.EstadoReparado = true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
