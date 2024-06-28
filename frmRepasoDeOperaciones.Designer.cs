namespace pryEstructuraDatos
{
    partial class frmRepasoDeOperaciones
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
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.lblListar = new System.Windows.Forms.Label();
            this.cmbOperaciones = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(12, 225);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.Size = new System.Drawing.Size(690, 254);
            this.dgvBaseDatos.TabIndex = 13;
            // 
            // lblListar
            // 
            this.lblListar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblListar.Location = new System.Drawing.Point(12, 77);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(690, 145);
            this.lblListar.TabIndex = 12;
            // 
            // cmbOperaciones
            // 
            this.cmbOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperaciones.FormattingEnabled = true;
            this.cmbOperaciones.Items.AddRange(new object[] {
            "UnionA",
            "UnionB",
            "IntersecciónA",
            "IntersecciónB",
            "DiferenciaA",
            "DiferenciaB",
            "Selección simpleA",
            "Selección simpleB",
            "Selección multiatributo por intersección A",
            "Selección multiatributo por intersección B",
            "Selección multiatributo por convolución A",
            "Selección multiatributo por convolución B",
            "Orden A",
            "Orden B",
            "Proyección por un atributo A",
            "Proyección por un atributo B",
            "Proyección multiatributo A",
            "Proyección multiatributo A",
            "Juntar A",
            "Juntar B"});
            this.cmbOperaciones.Location = new System.Drawing.Point(268, 23);
            this.cmbOperaciones.Name = "cmbOperaciones";
            this.cmbOperaciones.Size = new System.Drawing.Size(434, 23);
            this.cmbOperaciones.TabIndex = 11;
            this.cmbOperaciones.SelectedIndexChanged += new System.EventHandler(this.cmbOperaciones_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(9, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(253, 16);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Operación a realizar en la base de datos:";
            // 
            // frmRepasoDeOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 495);
            this.Controls.Add(this.dgvBaseDatos);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.cmbOperaciones);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmRepasoDeOperaciones";
            this.Text = "frmRepasoDeOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDatos;
        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.ComboBox cmbOperaciones;
        private System.Windows.Forms.Label lblTitulo;
    }
}