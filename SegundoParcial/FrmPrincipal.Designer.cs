namespace SegundoParcial
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCargarBarco = new Button();
            btnGuardar = new Button();
            labelNombreAlumno = new Label();
            txtNombreAlumno = new TextBox();
            btnReparaciones = new Button();
            btnVer = new Button();
            SuspendLayout();
            // 
            // btnCargarBarco
            // 
            btnCargarBarco.Location = new Point(12, 93);
            btnCargarBarco.Name = "btnCargarBarco";
            btnCargarBarco.Size = new Size(120, 23);
            btnCargarBarco.TabIndex = 0;
            btnCargarBarco.Text = "Cargar Barco";
            btnCargarBarco.UseVisualStyleBackColor = true;
            btnCargarBarco.Click += btnCargarBarco_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 64);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelNombreAlumno
            // 
            labelNombreAlumno.AutoSize = true;
            labelNombreAlumno.Location = new Point(12, 5);
            labelNombreAlumno.Name = "labelNombreAlumno";
            labelNombreAlumno.Size = new Size(100, 15);
            labelNombreAlumno.TabIndex = 2;
            labelNombreAlumno.Text = "Nombre Alumno:";
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(12, 23);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(172, 23);
            txtNombreAlumno.TabIndex = 3;
            // 
            // btnReparaciones
            // 
            btnReparaciones.Location = new Point(12, 122);
            btnReparaciones.Name = "btnReparaciones";
            btnReparaciones.Size = new Size(120, 23);
            btnReparaciones.TabIndex = 4;
            btnReparaciones.Text = "Reparaciones";
            btnReparaciones.UseVisualStyleBackColor = true;
            btnReparaciones.Click += btnReparaciones_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(12, 151);
            btnVer.Name = "btnVer";
            btnVer.RightToLeft = RightToLeft.Yes;
            btnVer.Size = new Size(120, 23);
            btnVer.TabIndex = 5;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 207);
            Controls.Add(btnVer);
            Controls.Add(btnReparaciones);
            Controls.Add(txtNombreAlumno);
            Controls.Add(labelNombreAlumno);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargarBarco);
            Name = "FrmPrincipal";
            Text = "FrmPrincipals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargarBarco;
        private Button btnGuardar;
        private Label labelNombreAlumno;
        private TextBox txtNombreAlumno;
        private Button btnReparaciones;
        private Button btnVer;
    }
}
