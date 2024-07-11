using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static ClassLibrary1.Barco;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibrary1
{
    [Serializable]
    public class Pirata : Barco
    {
        [XmlElement]
        private int tripulacion;

        public override int Tripulacion
        {
            get
            {
                return tripulacion;
            }
            set
            {
                tripulacion = GenerarRandom.EnteroAleatorio(10, 30);
            }
        }

        public Pirata() {   }
        public Pirata(string nombre, Barco.EOperacion operacion, float costo)
            : base(nombre, operacion, costo)
        {
            Tripulacion = GenerarRandom.EnteroAleatorio(10, 30); // Inicializa la tripulación en el constructor
        }

        public override void CalcularCostos(int max, int min)
        {
            this.costo = (float)GenerarRandom.DoubleAleatorio(2000, 12000);
        }
        
        public override bool CompararBarcos(Barco otroBarco)
        {
            if (otroBarco is Pirata)
                return Nombre == otroBarco.Nombre;
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("Tripulacion: ").Append(Tripulacion).Append("\n");
            sb.Append("Costo: ").Append(Costo).Append("\n");
            sb.Append("Tipo: ").Append(Barco.ETipoBarco.Pirata).Append("\n");
            return sb.ToString();
        }
    }
}
