using ClassLibrary1;
using System.Xml;
using System.Xml.Serialization;

namespace SegundoParcial
{
    public partial class FrmPrincipal : Form
    {
        private string nombreAlumno;
        private Taller taller;
        private XmlManager xmlManager = new XmlManager();

        string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "barcos.xml");

        public FrmPrincipal()
        {
            InitializeComponent();
            taller = new Taller();
            AccesoDatos.CrearTablaSiNoExiste();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarBarcosDesdeXML();
        }

        private void btnCargarBarco_Click(object sender, EventArgs e)
        {
            string textoIngresado = txtNombreAlumno.Text;
            FrmBarco frmAgregarBarco = new FrmBarco(textoIngresado, taller);
            DialogResult result = frmAgregarBarco.ShowDialog();

            if (result == DialogResult.OK)
            {
                Barco barco = frmAgregarBarco.BarcoAAgregar;

                if (!taller.EncontrarBarco(barco))
                {
                    if (taller.IngresarBarco(barco))
                    {
                        MessageBox.Show("Barco agregado al taller correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El barco ya está en el taller.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El barco ya está en el taller.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarTallerEnXML();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void CargarBarcosDesdeXML()
        {
            List<Barco> barcos = xmlManager.Leer(ruta);
            if (barcos != null && barcos.Count > 0)
            {
                foreach (var barco in barcos)
                {
                    taller.IngresarBarco(barco);
                }
                MessageBox.Show($"Barcos cargados desde el archivo XML: {taller.ListaBarcos.Count}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontraron barcos en el archivo XML o el archivo está vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GuardarTallerEnXML()
        {
            bool guardadoExitoso = xmlManager.Guardar(taller.ListaBarcos, ruta);
            if (guardadoExitoso)
            {
                MessageBox.Show("Taller guardado en archivo XML.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar taller en archivo XML.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReparaciones_Click(object sender, EventArgs e)
        {
            string rutaXML = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "barcos.xml");
            FrmReparacion reparacion = new FrmReparacion(rutaXML);
            reparacion.ShowDialog();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FrmVer ver = new FrmVer(taller);
            ver.ShowDialog();
        }
    }
}
