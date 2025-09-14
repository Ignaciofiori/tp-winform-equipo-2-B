namespace WindowsFormsFront
{
    partial class FormPrincipal
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.pbPricinpalArticulos = new System.Windows.Forms.PictureBox();
            this.lbCampo = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lbCriterio = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.tboFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPricinpalArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(14, 45);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.Size = new System.Drawing.Size(1194, 521);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(32, 572);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 38);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnModificar.Location = new System.Drawing.Point(151, 572);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 38);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEliminarFisico.Location = new System.Drawing.Point(261, 572);
            this.btnEliminarFisico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(104, 38);
            this.btnEliminarFisico.TabIndex = 5;
            this.btnEliminarFisico.Text = "Eliminar F.";
            this.btnEliminarFisico.UseVisualStyleBackColor = false;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // pbPricinpalArticulos
            // 
            this.pbPricinpalArticulos.Location = new System.Drawing.Point(1238, 45);
            this.pbPricinpalArticulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPricinpalArticulos.Name = "pbPricinpalArticulos";
            this.pbPricinpalArticulos.Size = new System.Drawing.Size(502, 521);
            this.pbPricinpalArticulos.TabIndex = 6;
            this.pbPricinpalArticulos.TabStop = false;
            this.pbPricinpalArticulos.Click += new System.EventHandler(this.pbPricinpalArticulos_Click);
            // 
            // lbCampo
            // 
            this.lbCampo.AutoSize = true;
            this.lbCampo.Location = new System.Drawing.Point(28, 648);
            this.lbCampo.Name = "lbCampo";
            this.lbCampo.Size = new System.Drawing.Size(60, 20);
            this.lbCampo.TabIndex = 7;
            this.lbCampo.Text = "Campo";
            // 
            // cboCampo
            // 
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(98, 644);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(192, 28);
            this.cboCampo.TabIndex = 8;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lbCriterio
            // 
            this.lbCriterio.AutoSize = true;
            this.lbCriterio.Location = new System.Drawing.Point(327, 648);
            this.lbCriterio.Name = "lbCriterio";
            this.lbCriterio.Size = new System.Drawing.Size(59, 20);
            this.lbCriterio.TabIndex = 9;
            this.lbCriterio.Text = "Criterio";
            // 
            // cboCriterio
            // 
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(395, 644);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(187, 28);
            this.cboCriterio.TabIndex = 10;
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(618, 648);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(44, 20);
            this.lbFiltro.TabIndex = 11;
            this.lbFiltro.Text = "Filtro";
            // 
            // tboFiltro
            // 
            this.tboFiltro.Location = new System.Drawing.Point(692, 646);
            this.tboFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboFiltro.Name = "tboFiltro";
            this.tboFiltro.Size = new System.Drawing.Size(195, 26);
            this.tboFiltro.TabIndex = 12;
            this.tboFiltro.TextChanged += new System.EventHandler(this.tboFiltro_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(934, 641);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(146, 39);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1790, 722);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tboFiltro);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lbCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lbCampo);
            this.Controls.Add(this.pbPricinpalArticulos);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion de Gestion: ";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPricinpalArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.PictureBox pbPricinpalArticulos;
        private System.Windows.Forms.Label lbCampo;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lbCriterio;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.TextBox tboFiltro;
        private System.Windows.Forms.Button btnBuscar;
    }
}

