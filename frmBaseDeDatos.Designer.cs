namespace pryEstructuraDatos
{
    partial class frmBaseDeDatos
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
            this.dgvBaseDeDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnProySimple = new System.Windows.Forms.Button();
            this.btnProyMul = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnConvolucion = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSelSim = new System.Windows.Forms.Button();
            this.btnDif = new System.Windows.Forms.Button();
            this.btnInter = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDeDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaseDeDatos
            // 
            this.dgvBaseDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDeDatos.Location = new System.Drawing.Point(6, 12);
            this.dgvBaseDeDatos.Name = "dgvBaseDeDatos";
            this.dgvBaseDeDatos.Size = new System.Drawing.Size(706, 328);
            this.dgvBaseDeDatos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJuntar);
            this.groupBox1.Controls.Add(this.btnProyMul);
            this.groupBox1.Controls.Add(this.btnProySimple);
            this.groupBox1.Location = new System.Drawing.Point(6, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de proyeccion - SELECT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConvolucion);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btnSelSim);
            this.groupBox2.Location = new System.Drawing.Point(252, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones de seleccion - WHERE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDif);
            this.groupBox3.Controls.Add(this.btnInter);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Location = new System.Drawing.Point(485, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones algebraicas";
            // 
            // btnProySimple
            // 
            this.btnProySimple.Location = new System.Drawing.Point(6, 19);
            this.btnProySimple.Name = "btnProySimple";
            this.btnProySimple.Size = new System.Drawing.Size(228, 23);
            this.btnProySimple.TabIndex = 0;
            this.btnProySimple.Text = "Proyección simple";
            this.btnProySimple.UseVisualStyleBackColor = true;
            // 
            // btnProyMul
            // 
            this.btnProyMul.Location = new System.Drawing.Point(6, 48);
            this.btnProyMul.Name = "btnProyMul";
            this.btnProyMul.Size = new System.Drawing.Size(228, 23);
            this.btnProyMul.TabIndex = 1;
            this.btnProyMul.Text = "Proyección multiatributo";
            this.btnProyMul.UseVisualStyleBackColor = true;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 77);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(228, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnConvolucion
            // 
            this.btnConvolucion.Location = new System.Drawing.Point(6, 77);
            this.btnConvolucion.Name = "btnConvolucion";
            this.btnConvolucion.Size = new System.Drawing.Size(216, 23);
            this.btnConvolucion.TabIndex = 5;
            this.btnConvolucion.Text = "Selección por convolución";
            this.btnConvolucion.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Selección multiatributo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnSelSim
            // 
            this.btnSelSim.Location = new System.Drawing.Point(6, 19);
            this.btnSelSim.Name = "btnSelSim";
            this.btnSelSim.Size = new System.Drawing.Size(216, 23);
            this.btnSelSim.TabIndex = 3;
            this.btnSelSim.Text = "Selección simple";
            this.btnSelSim.UseVisualStyleBackColor = true;
            // 
            // btnDif
            // 
            this.btnDif.Location = new System.Drawing.Point(6, 77);
            this.btnDif.Name = "btnDif";
            this.btnDif.Size = new System.Drawing.Size(216, 23);
            this.btnDif.TabIndex = 5;
            this.btnDif.Text = "Diferencia";
            this.btnDif.UseVisualStyleBackColor = true;
            // 
            // btnInter
            // 
            this.btnInter.Location = new System.Drawing.Point(6, 48);
            this.btnInter.Name = "btnInter";
            this.btnInter.Size = new System.Drawing.Size(216, 23);
            this.btnInter.TabIndex = 4;
            this.btnInter.Text = "Intersección";
            this.btnInter.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 19);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(216, 23);
            this.btnUnion.TabIndex = 3;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // frmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBaseDeDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDeDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDeDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyMul;
        private System.Windows.Forms.Button btnProySimple;
        private System.Windows.Forms.Button btnConvolucion;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSelSim;
        private System.Windows.Forms.Button btnDif;
        private System.Windows.Forms.Button btnInter;
        private System.Windows.Forms.Button btnUnion;
    }
}