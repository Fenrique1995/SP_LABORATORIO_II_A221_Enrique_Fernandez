namespace SegundoParcial
{
    partial class FrmVer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxDatos = new ListBox();
            btnEliminar = new Button();
            btnEdit = new Button();
            textBoxNuevoMensaje = new TextBox();
            SuspendLayout();
            // 
            // listBoxDatos
            // 
            listBoxDatos.FormattingEnabled = true;
            listBoxDatos.ItemHeight = 15;
            listBoxDatos.Location = new Point(12, 15);
            listBoxDatos.Name = "listBoxDatos";
            listBoxDatos.Size = new Size(563, 304);
            listBoxDatos.TabIndex = 0;
            listBoxDatos.SelectedIndexChanged += listBoxDatos_SelectedIndexChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(591, 293);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 25);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(671, 188);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(114, 25);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // textBoxNuevoMensaje
            // 
            textBoxNuevoMensaje.Location = new Point(591, 21);
            textBoxNuevoMensaje.Multiline = true;
            textBoxNuevoMensaje.Name = "textBoxNuevoMensaje";
            textBoxNuevoMensaje.Size = new Size(265, 161);
            textBoxNuevoMensaje.TabIndex = 3;
            // 
            // FrmVer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 330);
            Controls.Add(textBoxNuevoMensaje);
            Controls.Add(btnEdit);
            Controls.Add(btnEliminar);
            Controls.Add(listBoxDatos);
            Name = "FrmVer";
            Text = "Ver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxDatos;
        private Button btnEliminar;
        private Button btnEdit;
        private TextBox textBoxNuevoMensaje;
    }
}