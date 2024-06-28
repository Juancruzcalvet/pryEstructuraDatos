namespace pryEstructuraDatos
{
    partial class frmBDOperaciones
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
            this.mrcSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSeleccionPorConvolucion = new System.Windows.Forms.Button();
            this.btnSeleccionMultiatributo = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.mrcOperaciones = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.mrcProyeccion = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyeccionMultiatributo = new System.Windows.Forms.Button();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.mrcSeleccion.SuspendLayout();
            this.mrcOperaciones.SuspendLayout();
            this.mrcProyeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcSeleccion
            // 
            this.mrcSeleccion.Controls.Add(this.btnSeleccionPorConvolucion);
            this.mrcSeleccion.Controls.Add(this.btnSeleccionMultiatributo);
            this.mrcSeleccion.Controls.Add(this.btnSeleccionSimple);
            this.mrcSeleccion.Location = new System.Drawing.Point(295, 288);
            this.mrcSeleccion.Name = "mrcSeleccion";
            this.mrcSeleccion.Size = new System.Drawing.Size(258, 109);
            this.mrcSeleccion.TabIndex = 10;
            this.mrcSeleccion.TabStop = false;
            this.mrcSeleccion.Text = "Operaciones de Selección - WHERE";
            // 
            // btnSeleccionPorConvolucion
            // 
            this.btnSeleccionPorConvolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionPorConvolucion.Location = new System.Drawing.Point(6, 79);
            this.btnSeleccionPorConvolucion.Name = "btnSeleccionPorConvolucion";
            this.btnSeleccionPorConvolucion.Size = new System.Drawing.Size(246, 23);
            this.btnSeleccionPorConvolucion.TabIndex = 2;
            this.btnSeleccionPorConvolucion.Text = "Selección por convolución";
            this.btnSeleccionPorConvolucion.UseVisualStyleBackColor = true;
            this.btnSeleccionPorConvolucion.Click += new System.EventHandler(this.btnSeleccionPorConvolucion_Click);
            // 
            // btnSeleccionMultiatributo
            // 
            this.btnSeleccionMultiatributo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionMultiatributo.Location = new System.Drawing.Point(6, 49);
            this.btnSeleccionMultiatributo.Name = "btnSeleccionMultiatributo";
            this.btnSeleccionMultiatributo.Size = new System.Drawing.Size(246, 23);
            this.btnSeleccionMultiatributo.TabIndex = 1;
            this.btnSeleccionMultiatributo.Text = "Selección multiatributo";
            this.btnSeleccionMultiatributo.UseVisualStyleBackColor = true;
            this.btnSeleccionMultiatributo.Click += new System.EventHandler(this.btnSeleccionMultiatributo_Click);
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionSimple.Location = new System.Drawing.Point(6, 19);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(246, 23);
            this.btnSeleccionSimple.TabIndex = 0;
            this.btnSeleccionSimple.Text = "Selección simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // mrcOperaciones
            // 
            this.mrcOperaciones.Controls.Add(this.btnDiferencia);
            this.mrcOperaciones.Controls.Add(this.btnInterseccion);
            this.mrcOperaciones.Controls.Add(this.btnUnion);
            this.mrcOperaciones.Location = new System.Drawing.Point(569, 288);
            this.mrcOperaciones.Name = "mrcOperaciones";
            this.mrcOperaciones.Size = new System.Drawing.Size(258, 109);
            this.mrcOperaciones.TabIndex = 11;
            this.mrcOperaciones.TabStop = false;
            this.mrcOperaciones.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiferencia.Location = new System.Drawing.Point(6, 77);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(244, 23);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInterseccion.Location = new System.Drawing.Point(6, 48);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(244, 23);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnion.Location = new System.Drawing.Point(6, 19);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(244, 23);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // mrcProyeccion
            // 
            this.mrcProyeccion.Controls.Add(this.btnJuntar);
            this.mrcProyeccion.Controls.Add(this.btnProyeccionMultiatributo);
            this.mrcProyeccion.Controls.Add(this.btnProyeccionSimple);
            this.mrcProyeccion.Location = new System.Drawing.Point(12, 288);
            this.mrcProyeccion.Name = "mrcProyeccion";
            this.mrcProyeccion.Size = new System.Drawing.Size(258, 109);
            this.mrcProyeccion.TabIndex = 9;
            this.mrcProyeccion.TabStop = false;
            this.mrcProyeccion.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJuntar.Location = new System.Drawing.Point(9, 77);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(243, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnProyeccionMultiatributo
            // 
            this.btnProyeccionMultiatributo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyeccionMultiatributo.Location = new System.Drawing.Point(10, 49);
            this.btnProyeccionMultiatributo.Name = "btnProyeccionMultiatributo";
            this.btnProyeccionMultiatributo.Size = new System.Drawing.Size(242, 23);
            this.btnProyeccionMultiatributo.TabIndex = 1;
            this.btnProyeccionMultiatributo.Text = "Proyección multiatributo";
            this.btnProyeccionMultiatributo.UseVisualStyleBackColor = true;
            this.btnProyeccionMultiatributo.Click += new System.EventHandler(this.btnProyeccionMultiatributo_Click);
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyeccionSimple.Location = new System.Drawing.Point(10, 20);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(242, 23);
            this.btnProyeccionSimple.TabIndex = 0;
            this.btnProyeccionSimple.Text = "Proyección simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.Size = new System.Drawing.Size(815, 248);
            this.dgvBaseDatos.TabIndex = 8;
            // 
            // frmBDOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 407);
            this.Controls.Add(this.mrcSeleccion);
            this.Controls.Add(this.mrcOperaciones);
            this.Controls.Add(this.mrcProyeccion);
            this.Controls.Add(this.dgvBaseDatos);
            this.Name = "frmBDOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones de Base de Datos";
            this.mrcSeleccion.ResumeLayout(false);
            this.mrcOperaciones.ResumeLayout(false);
            this.mrcProyeccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcSeleccion;
        private System.Windows.Forms.Button btnSeleccionPorConvolucion;
        private System.Windows.Forms.Button btnSeleccionMultiatributo;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.GroupBox mrcOperaciones;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.GroupBox mrcProyeccion;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyeccionMultiatributo;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.DataGridView dgvBaseDatos;
    }
}