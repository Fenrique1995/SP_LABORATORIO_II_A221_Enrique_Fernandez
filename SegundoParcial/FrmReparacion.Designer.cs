namespace SegundoParcial
{
    partial class FrmReparacion
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
            listBoxBarcos = new ListBox();
            textBoxXml = new TextBox();
            dataGridViewBarcos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBarcos).BeginInit();
            SuspendLayout();
            // 
            // listBoxBarcos
            // 
            listBoxBarcos.FormattingEnabled = true;
            listBoxBarcos.ItemHeight = 15;
            listBoxBarcos.Location = new Point(33, 8);
            listBoxBarcos.Name = "listBoxBarcos";
            listBoxBarcos.Size = new Size(45, 34);
            listBoxBarcos.TabIndex = 0;
            // 
            // textBoxXml
            // 
            textBoxXml.Location = new Point(84, 8);
            textBoxXml.Multiline = true;
            textBoxXml.Name = "textBoxXml";
            textBoxXml.Size = new Size(612, 53);
            textBoxXml.TabIndex = 1;
            // 
            // dataGridViewBarcos
            // 
            dataGridViewBarcos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBarcos.Location = new Point(50, 127);
            dataGridViewBarcos.Name = "dataGridViewBarcos";
            dataGridViewBarcos.Size = new Size(382, 121);
            dataGridViewBarcos.TabIndex = 2;
            // 
            // FrmReparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 285);
            Controls.Add(dataGridViewBarcos);
            Controls.Add(textBoxXml);
            Controls.Add(listBoxBarcos);
            Name = "FrmReparacion";
            Text = "FrmReparacion";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBarcos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBarcos;
        private TextBox textBoxXml;
        private DataGridView dataGridViewBarcos;
    }
}