namespace SegundoParcial
{
    partial class FrmBarco
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
            comboBoxTipoBarco = new ComboBox();
            textBoxNombre = new TextBox();
            comboBoxOperacion = new ComboBox();
            labelNombreBarco = new Label();
            labelTipoDeBarco = new Label();
            labelTipoDeOperacion = new Label();
            btnCargar = new Button();
            SuspendLayout();
            // 
            // comboBoxTipoBarco
            // 
            comboBoxTipoBarco.FormattingEnabled = true;
            comboBoxTipoBarco.Location = new Point(12, 165);
            comboBoxTipoBarco.Name = "comboBoxTipoBarco";
            comboBoxTipoBarco.Size = new Size(121, 23);
            comboBoxTipoBarco.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(12, 95);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(121, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // comboBoxOperacion
            // 
            comboBoxOperacion.FormattingEnabled = true;
            comboBoxOperacion.Location = new Point(170, 165);
            comboBoxOperacion.Name = "comboBoxOperacion";
            comboBoxOperacion.Size = new Size(121, 23);
            comboBoxOperacion.TabIndex = 2;
            // 
            // labelNombreBarco
            // 
            labelNombreBarco.AutoSize = true;
            labelNombreBarco.Location = new Point(12, 68);
            labelNombreBarco.Name = "labelNombreBarco";
            labelNombreBarco.Size = new Size(87, 15);
            labelNombreBarco.TabIndex = 3;
            labelNombreBarco.Text = "Nombre Barco:";
            // 
            // labelTipoDeBarco
            // 
            labelTipoDeBarco.AutoSize = true;
            labelTipoDeBarco.Location = new Point(12, 147);
            labelTipoDeBarco.Name = "labelTipoDeBarco";
            labelTipoDeBarco.Size = new Size(83, 15);
            labelTipoDeBarco.TabIndex = 4;
            labelTipoDeBarco.Text = "Tipo De Barco:";
            // 
            // labelTipoDeOperacion
            // 
            labelTipoDeOperacion.AutoSize = true;
            labelTipoDeOperacion.Location = new Point(170, 147);
            labelTipoDeOperacion.Name = "labelTipoDeOperacion";
            labelTipoDeOperacion.Size = new Size(108, 15);
            labelTipoDeOperacion.TabIndex = 5;
            labelTipoDeOperacion.Text = "Tipo De Operacion:";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(112, 222);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 6;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click_1;
            // 
            // FrmBarco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 263);
            Controls.Add(btnCargar);
            Controls.Add(labelTipoDeOperacion);
            Controls.Add(labelTipoDeBarco);
            Controls.Add(labelNombreBarco);
            Controls.Add(comboBoxOperacion);
            Controls.Add(textBoxNombre);
            Controls.Add(comboBoxTipoBarco);
            Name = "FrmBarco";
            Text = "FrmBarco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTipoBarco;
        private TextBox textBoxNombre;
        private ComboBox comboBoxOperacion;
        private Label labelNombreBarco;
        private Label labelTipoDeBarco;
        private Label labelTipoDeOperacion;
        private Button btnCargar;
    }
}