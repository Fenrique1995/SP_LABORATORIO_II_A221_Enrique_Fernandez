using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class FrmBarco : Form
    {
        public Barco BarcoAAgregar { get; private set; }
        private string textoIngresado;
        private Taller taller;

        public FrmBarco(string textoDesdeForm1, Taller taller)
        {
            InitializeComponent();
            textoIngresado = textoDesdeForm1;
            this.taller = taller;

            // Configurar ComboBox de Operaciones
            comboBoxOperacion.DataSource = Enum.GetValues(typeof(Barco.EOperacion));

            // Configurar ComboBox de Tipos de Barco
            comboBoxTipoBarco.DataSource = Enum.GetValues(typeof(Barco.ETipoBarco));
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            if (textBoxNombre == null || comboBoxOperacion == null || comboBoxTipoBarco == null)
            {
                MessageBox.Show("Algunos de los controles no están inicializados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = textBoxNombre.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre para el barco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxOperacion.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una operación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Barco.EOperacion operacion = (Barco.EOperacion)comboBoxOperacion.SelectedItem;

            if (comboBoxTipoBarco.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de barco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float costo = (float)GenerarRandom.DoubleAleatorio(1000, 5000); // Ejemplo de costo

            if (comboBoxTipoBarco.SelectedItem.ToString() == "Marina")
            {
                BarcoAAgregar = new Marina(nombre, operacion, costo);
            }
            else
            {
                BarcoAAgregar = new Pirata(nombre, operacion, costo);
            }

            // Asegurar que textoIngresado no esté vacío o null
            if (string.IsNullOrEmpty(textoIngresado))
            {
                MessageBox.Show("Debe ingresar un valor para 'textoIngresado'.");
                return;
            }

            // Llamar correctamente a ToString() en BarcoAAgregar
            AccesoDatos.GuardarReparacion(BarcoAAgregar.ToString(), textoIngresado);

            // Agregar el barco al taller
            //taller.IngresarBarco(BarcoAAgregar);

            DialogResult = DialogResult.OK;
        }
    }
}
