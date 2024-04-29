namespace pryEstructuraDatos
{
    partial class frmArbolBinario
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
            this.grpVista = new System.Windows.Forms.GroupBox();
            this.dgvEstructuraCola = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.optOrdAsc = new System.Windows.Forms.RadioButton();
            this.optPost = new System.Windows.Forms.RadioButton();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.tvwArbol = new System.Windows.Forms.TreeView();
            this.optOrdDesc = new System.Windows.Forms.RadioButton();
            this.grpVista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstructuraCola)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVista
            // 
            this.grpVista.Controls.Add(this.optOrdDesc);
            this.grpVista.Controls.Add(this.optPostOrden);
            this.grpVista.Controls.Add(this.optPost);
            this.grpVista.Controls.Add(this.optOrdAsc);
            this.grpVista.Controls.Add(this.dgvEstructuraCola);
            this.grpVista.Location = new System.Drawing.Point(12, 238);
            this.grpVista.Name = "grpVista";
            this.grpVista.Size = new System.Drawing.Size(732, 328);
            this.grpVista.TabIndex = 30;
            this.grpVista.TabStop = false;
            this.grpVista.Text = "Listado del árbol";
            // 
            // dgvEstructuraCola
            // 
            this.dgvEstructuraCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstructuraCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Trámite});
            this.dgvEstructuraCola.Location = new System.Drawing.Point(240, 19);
            this.dgvEstructuraCola.Name = "dgvEstructuraCola";
            this.dgvEstructuraCola.Size = new System.Drawing.Size(486, 303);
            this.dgvEstructuraCola.TabIndex = 11;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Trámite
            // 
            this.Trámite.HeaderText = "Trámite";
            this.Trámite.Name = "Trámite";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCodigo);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(513, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 145);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elemento a eliminar";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(52, 35);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(154, 21);
            this.cmbCodigo.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 70);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(217, 50);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtTramite);
            this.groupBox1.Controls.Add(this.txtNombreNuevo);
            this.groupBox1.Controls.Add(this.txtCodigoNuevo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(278, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 220);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 185);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 29);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(61, 133);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(148, 20);
            this.txtTramite.TabIndex = 8;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(61, 86);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(148, 20);
            this.txtNombreNuevo.TabIndex = 7;
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(61, 38);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(148, 20);
            this.txtCodigoNuevo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trámite:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(513, 176);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(223, 50);
            this.btnEquilibrar.TabIndex = 11;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // optOrdAsc
            // 
            this.optOrdAsc.AutoSize = true;
            this.optOrdAsc.Location = new System.Drawing.Point(65, 78);
            this.optOrdAsc.Name = "optOrdAsc";
            this.optOrdAsc.Size = new System.Drawing.Size(126, 17);
            this.optOrdAsc.TabIndex = 12;
            this.optOrdAsc.TabStop = true;
            this.optOrdAsc.Text = "In-Orden Ascendente";
            this.optOrdAsc.UseVisualStyleBackColor = true;
            // 
            // optPost
            // 
            this.optPost.AutoSize = true;
            this.optPost.Location = new System.Drawing.Point(65, 180);
            this.optPost.Name = "optPost";
            this.optPost.Size = new System.Drawing.Size(73, 17);
            this.optPost.TabIndex = 13;
            this.optPost.TabStop = true;
            this.optPost.Text = "Pre-Orden";
            this.optPost.UseVisualStyleBackColor = true;
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(65, 231);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(78, 17);
            this.optPostOrden.TabIndex = 14;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            // 
            // tvwArbol
            // 
            this.tvwArbol.Location = new System.Drawing.Point(12, 12);
            this.tvwArbol.Name = "tvwArbol";
            this.tvwArbol.Size = new System.Drawing.Size(260, 220);
            this.tvwArbol.TabIndex = 31;
            // 
            // optOrdDesc
            // 
            this.optOrdDesc.AutoSize = true;
            this.optOrdDesc.Location = new System.Drawing.Point(65, 129);
            this.optOrdDesc.Name = "optOrdDesc";
            this.optOrdDesc.Size = new System.Drawing.Size(133, 17);
            this.optOrdDesc.TabIndex = 15;
            this.optOrdDesc.TabStop = true;
            this.optOrdDesc.Text = "In-Orden Descendente";
            this.optOrdDesc.UseVisualStyleBackColor = true;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 578);
            this.Controls.Add(this.tvwArbol);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.grpVista);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmArbolBinario";
            this.Text = "Estructurar ramificadas - Árbol binario";
            this.grpVista.ResumeLayout(false);
            this.grpVista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstructuraCola)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpVista;
        private System.Windows.Forms.DataGridView dgvEstructuraCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optOrdDesc;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPost;
        private System.Windows.Forms.RadioButton optOrdAsc;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.TreeView tvwArbol;
    }
}