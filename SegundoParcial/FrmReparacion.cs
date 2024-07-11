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
using System.Xml.Serialization;

namespace SegundoParcial
{
    public partial class FrmReparacion : Form
    {
        private XmlManager xmlManager = new XmlManager();
        private string ruta;

        public FrmReparacion(string ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
        }

        private void FrmReparacion_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar barcos desde el archivo XML
                List<Barco> barcos = xmlManager.Leer(ruta);
                if (barcos != null && barcos.Count > 0)
                {
                    dataGridViewBarcos.DataSource = barcos;
                    /*textBoxXml.Clear(); // Limpiar el TextBox antes de agregar contenido nuevo
                    foreach (var b in barcos)
                    {
                        textBoxXml.AppendText(b.ToString() + Environment.NewLine); // Agregar cada barco al TextBox
                    }*/
                }
                else
                {
                    MessageBox.Show("No se encontraron barcos en el archivo XML o el archivo está vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar y mostrar los barcos desde el archivo XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
