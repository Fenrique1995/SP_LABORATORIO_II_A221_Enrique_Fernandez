using System.Text;
using System.Xml.Serialization;

namespace ClassLibrary1
{
    [XmlInclude(typeof(Marina))]
    [XmlInclude(typeof(Pirata))]

    [Serializable]
    public abstract class Barco
    {
        public enum EOperacion
        {
            Reparar_Mastil,
            Pintar,
            Cambiar_Velas,
            Reparar_Mascaron,
            Reparar_Casco,
            Recargar_Cañones
        }

        public enum ETipoBarco
        {
            Pirata,
            Marina
        }
        [XmlElement]
        protected float costo;
        private bool estadoReparado;
        private string nombre;
        private EOperacion operacion;

        public Barco() { }

        public Barco(string nombre, EOperacion operacion, float costo)
        {
            this.nombre = nombre;
            this.operacion = operacion;
            this.costo = costo;
            this.estadoReparado = false; // Inicializa el estado reparado a falso
        }
        [XmlElement]
        public string Nombre { get { return nombre; } set { nombre = value; } }
        [XmlElement]
        public bool EstadoReparado { get { return this.estadoReparado; } set { this.estadoReparado = value; } }
        [XmlElement]
        public EOperacion Operacion { get { return this.operacion; } }
        [XmlElement]
        public float Costo { get { return this.costo; } }
        [XmlElement]
        public abstract int Tripulacion { get; set; }
        
        public abstract void CalcularCostos(int max, int min);
        
        public abstract bool CompararBarcos(Barco otroBarco);
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: ").Append(Nombre).Append("\n");
            sb.Append("Operación: ").Append(Operacion).Append("\n");
            sb.Append("Estado Reparado: ").Append(EstadoReparado).Append("\n");
            return sb.ToString();
        }
    }
}
