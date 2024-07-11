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
    public partial class FrmVer : Form
    {
        private Taller taller;
        private string mensajeSeleccionado;

        public FrmVer(Taller taller)
        {
            InitializeComponent();
            this.taller = taller;
            CargarReparacionesEnListBox();
        }

        private void CargarReparacionesEnListBox()
        {
            listBoxDatos.Items.Clear();
            List<string> reparaciones = AccesoDatos.LeerReparaciones();
            foreach (string reparacion in reparaciones)
            {
                listBoxDatos.Items.Add(reparacion);
            }
        }

        private void listBoxDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDatos.SelectedItem != null)
            {
                mensajeSeleccionado = listBoxDatos.SelectedItem.ToString();
                textBoxNuevoMensaje.Text = mensajeSeleccionado; // Mostrar el mensaje seleccionado en el campo de texto
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNuevoMensaje.Text))
            {
                MessageBox.Show("Debe ingresar un nuevo mensaje.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llamar a AccesoDatos para actualizar el mensaje
            AccesoDatos.ActualizarMensajeReparacion(mensajeSeleccionado, textBoxNuevoMensaje.Text);

            // Actualizar la ListBox con los cambios
            CargarReparacionesEnListBox();

            // Limpiar el campo de texto después de editar
            textBoxNuevoMensaje.Text = string.Empty;

            MessageBox.Show("Mensaje actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxDatos.SelectedItem != null)
            {
                string selectedReparacion = listBoxDatos.SelectedItem.ToString();

                // Confirmar eliminación
                DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar la reparación: {selectedReparacion}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    AccesoDatos.EliminarReparacion(selectedReparacion);
                    CargarReparacionesEnListBox();
                    MessageBox.Show("Reparación eliminada correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una reparación para eliminar.");
            }
        }
    }
}
