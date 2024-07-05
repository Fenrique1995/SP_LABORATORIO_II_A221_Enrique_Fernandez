namespace ClassLibrary1
{
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

        float costo;
        bool estadoReparado;
        string nombre;
        EOperacion operacion;
        int tripulacion;

        protected Barco()
        {
        }
        protected Barco(string nombre, int tripulacion, EOperacion operacion)
        {
            this.nombre = nombre;
            this.tripulacion = tripulacion;
            this.operacion = operacion;
        }

        public string Nombre { get { return this.nombre; } }

        public bool EstadoReparado { get { return true; } }

        public EOperacion Operacion { get { return this.operacion; } }

        public float Costo { get { return this.costo; } }

        public abstract int Tripulacion { get; }

        public void CalcularCostos(int max, int min)
        {
            GenerarRandom.DoubleAleatorio(max,min);
        }
    }
}
