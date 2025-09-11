namespace WindowsFormsFront
{
    partial class ArticuloCrearForm
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelCodArticulo = new System.Windows.Forms.Label();
            this.CodArticuloTextBox = new System.Windows.Forms.TextBox();
            this.labelNombreArticulo = new System.Windows.Forms.Label();
            this.NombreArticuloTextBox = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.DescripcionArticuloTextBox = new System.Windows.Forms.TextBox();
            this.MarcaArticuloComboBox = new System.Windows.Forms.ComboBox();
            this.CategoriaArticuloComboBox = new System.Windows.Forms.ComboBox();
            this.labelMarcaArticulo = new System.Windows.Forms.Label();
            this.labelCategoriaArticulo = new System.Windows.Forms.Label();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.CrearArticuloButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(367, 65);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(97, 16);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Nuevo Articulo:";
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCodArticulo
            // 
            this.labelCodArticulo.AutoSize = true;
            this.labelCodArticulo.Location = new System.Drawing.Point(111, 152);
            this.labelCodArticulo.Name = "labelCodArticulo";
            this.labelCodArticulo.Size = new System.Drawing.Size(120, 16);
            this.labelCodArticulo.TabIndex = 1;
            this.labelCodArticulo.Text = "Codigo de Articulo:";
            this.labelCodArticulo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CodArticuloTextBox
            // 
            this.CodArticuloTextBox.Location = new System.Drawing.Point(255, 146);
            this.CodArticuloTextBox.Name = "CodArticuloTextBox";
            this.CodArticuloTextBox.Size = new System.Drawing.Size(192, 22);
            this.CodArticuloTextBox.TabIndex = 2;
            // 
            // labelNombreArticulo
            // 
            this.labelNombreArticulo.AutoSize = true;
            this.labelNombreArticulo.Location = new System.Drawing.Point(106, 196);
            this.labelNombreArticulo.Name = "labelNombreArticulo";
            this.labelNombreArticulo.Size = new System.Drawing.Size(125, 16);
            this.labelNombreArticulo.TabIndex = 3;
            this.labelNombreArticulo.Text = "Nombre de Articulo:";
            // 
            // NombreArticuloTextBox
            // 
            this.NombreArticuloTextBox.Location = new System.Drawing.Point(255, 196);
            this.NombreArticuloTextBox.Name = "NombreArticuloTextBox";
            this.NombreArticuloTextBox.Size = new System.Drawing.Size(192, 22);
            this.NombreArticuloTextBox.TabIndex = 4;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(149, 236);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(82, 16);
            this.labelDescripcion.TabIndex = 5;
            this.labelDescripcion.Text = "Descripcion:";
            this.labelDescripcion.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // DescripcionArticuloTextBox
            // 
            this.DescripcionArticuloTextBox.Location = new System.Drawing.Point(255, 236);
            this.DescripcionArticuloTextBox.Name = "DescripcionArticuloTextBox";
            this.DescripcionArticuloTextBox.Size = new System.Drawing.Size(413, 22);
            this.DescripcionArticuloTextBox.TabIndex = 6;
            // 
            // MarcaArticuloComboBox
            // 
            this.MarcaArticuloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarcaArticuloComboBox.FormattingEnabled = true;
            this.MarcaArticuloComboBox.Location = new System.Drawing.Point(255, 296);
            this.MarcaArticuloComboBox.Name = "MarcaArticuloComboBox";
            this.MarcaArticuloComboBox.Size = new System.Drawing.Size(209, 24);
            this.MarcaArticuloComboBox.TabIndex = 7;
            // 
            // CategoriaArticuloComboBox
            // 
            this.CategoriaArticuloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriaArticuloComboBox.FormattingEnabled = true;
            this.CategoriaArticuloComboBox.Location = new System.Drawing.Point(255, 344);
            this.CategoriaArticuloComboBox.Name = "CategoriaArticuloComboBox";
            this.CategoriaArticuloComboBox.Size = new System.Drawing.Size(209, 24);
            this.CategoriaArticuloComboBox.TabIndex = 8;
            // 
            // labelMarcaArticulo
            // 
            this.labelMarcaArticulo.AutoSize = true;
            this.labelMarcaArticulo.Location = new System.Drawing.Point(183, 296);
            this.labelMarcaArticulo.Name = "labelMarcaArticulo";
            this.labelMarcaArticulo.Size = new System.Drawing.Size(48, 16);
            this.labelMarcaArticulo.TabIndex = 9;
            this.labelMarcaArticulo.Text = "Marca:";
            this.labelMarcaArticulo.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // labelCategoriaArticulo
            // 
            this.labelCategoriaArticulo.AutoSize = true;
            this.labelCategoriaArticulo.Location = new System.Drawing.Point(162, 352);
            this.labelCategoriaArticulo.Name = "labelCategoriaArticulo";
            this.labelCategoriaArticulo.Size = new System.Drawing.Size(69, 16);
            this.labelCategoriaArticulo.TabIndex = 10;
            this.labelCategoriaArticulo.Text = "Categoria:";
            this.labelCategoriaArticulo.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(255, 416);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(146, 22);
            this.PrecioNumericUpDown.TabIndex = 11;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(162, 422);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(49, 16);
            this.labelPrecio.TabIndex = 12;
            this.labelPrecio.Text = "Precio:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(418, 528);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(118, 23);
            this.CancelarButton.TabIndex = 13;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrearArticuloButton
            // 
            this.CrearArticuloButton.Location = new System.Drawing.Point(204, 528);
            this.CrearArticuloButton.Name = "CrearArticuloButton";
            this.CrearArticuloButton.Size = new System.Drawing.Size(118, 23);
            this.CrearArticuloButton.TabIndex = 14;
            this.CrearArticuloButton.Text = "Crear";
            this.CrearArticuloButton.UseVisualStyleBackColor = true;
            this.CrearArticuloButton.Click += new System.EventHandler(this.CrearArticuloButton_Click);
            // 
            // ArticuloCrearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 633);
            this.Controls.Add(this.CrearArticuloButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.labelCategoriaArticulo);
            this.Controls.Add(this.labelMarcaArticulo);
            this.Controls.Add(this.CategoriaArticuloComboBox);
            this.Controls.Add(this.MarcaArticuloComboBox);
            this.Controls.Add(this.DescripcionArticuloTextBox);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.NombreArticuloTextBox);
            this.Controls.Add(this.labelNombreArticulo);
            this.Controls.Add(this.CodArticuloTextBox);
            this.Controls.Add(this.labelCodArticulo);
            this.Controls.Add(this.labelTitulo);
            this.Name = "ArticuloCrearForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Articulo:";
            this.Load += new System.EventHandler(this.ArticuloCrearForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelCodArticulo;
        private System.Windows.Forms.TextBox CodArticuloTextBox;
        private System.Windows.Forms.Label labelNombreArticulo;
        private System.Windows.Forms.TextBox NombreArticuloTextBox;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox DescripcionArticuloTextBox;
        private System.Windows.Forms.ComboBox MarcaArticuloComboBox;
        private System.Windows.Forms.ComboBox CategoriaArticuloComboBox;
        private System.Windows.Forms.Label labelMarcaArticulo;
        private System.Windows.Forms.Label labelCategoriaArticulo;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button CrearArticuloButton;
    }
}