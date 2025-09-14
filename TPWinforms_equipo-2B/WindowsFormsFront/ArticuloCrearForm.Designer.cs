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
            this.ImagenTextBox = new System.Windows.Forms.TextBox();
            this.labelImagen = new System.Windows.Forms.Label();
            this.pbImagenCrear = new System.Windows.Forms.PictureBox();
            this.buttonAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCrear)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodArticulo
            // 
            this.labelCodArticulo.AutoSize = true;
            this.labelCodArticulo.Location = new System.Drawing.Point(33, 66);
            this.labelCodArticulo.Name = "labelCodArticulo";
            this.labelCodArticulo.Size = new System.Drawing.Size(142, 20);
            this.labelCodArticulo.TabIndex = 1;
            this.labelCodArticulo.Text = "Codigo de Articulo:";
            this.labelCodArticulo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CodArticuloTextBox
            // 
            this.CodArticuloTextBox.Location = new System.Drawing.Point(174, 62);
            this.CodArticuloTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CodArticuloTextBox.Name = "CodArticuloTextBox";
            this.CodArticuloTextBox.Size = new System.Drawing.Size(235, 26);
            this.CodArticuloTextBox.TabIndex = 2;
            // 
            // labelNombreArticulo
            // 
            this.labelNombreArticulo.AutoSize = true;
            this.labelNombreArticulo.Location = new System.Drawing.Point(27, 108);
            this.labelNombreArticulo.Name = "labelNombreArticulo";
            this.labelNombreArticulo.Size = new System.Drawing.Size(148, 20);
            this.labelNombreArticulo.TabIndex = 3;
            this.labelNombreArticulo.Text = "Nombre de Articulo:";
            // 
            // NombreArticuloTextBox
            // 
            this.NombreArticuloTextBox.Location = new System.Drawing.Point(174, 108);
            this.NombreArticuloTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NombreArticuloTextBox.Name = "NombreArticuloTextBox";
            this.NombreArticuloTextBox.Size = new System.Drawing.Size(235, 26);
            this.NombreArticuloTextBox.TabIndex = 4;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(71, 156);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(96, 20);
            this.labelDescripcion.TabIndex = 5;
            this.labelDescripcion.Text = "Descripcion:";
            this.labelDescripcion.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // DescripcionArticuloTextBox
            // 
            this.DescripcionArticuloTextBox.Location = new System.Drawing.Point(174, 156);
            this.DescripcionArticuloTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescripcionArticuloTextBox.Name = "DescripcionArticuloTextBox";
            this.DescripcionArticuloTextBox.Size = new System.Drawing.Size(235, 26);
            this.DescripcionArticuloTextBox.TabIndex = 6;
            // 
            // MarcaArticuloComboBox
            // 
            this.MarcaArticuloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarcaArticuloComboBox.FormattingEnabled = true;
            this.MarcaArticuloComboBox.Location = new System.Drawing.Point(174, 204);
            this.MarcaArticuloComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MarcaArticuloComboBox.Name = "MarcaArticuloComboBox";
            this.MarcaArticuloComboBox.Size = new System.Drawing.Size(235, 28);
            this.MarcaArticuloComboBox.TabIndex = 7;
            this.MarcaArticuloComboBox.SelectedIndexChanged += new System.EventHandler(this.MarcaArticuloComboBox_SelectedIndexChanged);
            // 
            // CategoriaArticuloComboBox
            // 
            this.CategoriaArticuloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriaArticuloComboBox.FormattingEnabled = true;
            this.CategoriaArticuloComboBox.Location = new System.Drawing.Point(174, 264);
            this.CategoriaArticuloComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CategoriaArticuloComboBox.Name = "CategoriaArticuloComboBox";
            this.CategoriaArticuloComboBox.Size = new System.Drawing.Size(235, 28);
            this.CategoriaArticuloComboBox.TabIndex = 8;
            // 
            // labelMarcaArticulo
            // 
            this.labelMarcaArticulo.AutoSize = true;
            this.labelMarcaArticulo.Location = new System.Drawing.Point(94, 214);
            this.labelMarcaArticulo.Name = "labelMarcaArticulo";
            this.labelMarcaArticulo.Size = new System.Drawing.Size(57, 20);
            this.labelMarcaArticulo.TabIndex = 9;
            this.labelMarcaArticulo.Text = "Marca:";
            this.labelMarcaArticulo.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // labelCategoriaArticulo
            // 
            this.labelCategoriaArticulo.AutoSize = true;
            this.labelCategoriaArticulo.Location = new System.Drawing.Point(71, 264);
            this.labelCategoriaArticulo.Name = "labelCategoriaArticulo";
            this.labelCategoriaArticulo.Size = new System.Drawing.Size(82, 20);
            this.labelCategoriaArticulo.TabIndex = 10;
            this.labelCategoriaArticulo.Text = "Categoria:";
            this.labelCategoriaArticulo.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(174, 330);
            this.PrecioNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(235, 26);
            this.PrecioNumericUpDown.TabIndex = 11;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(93, 330);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(57, 20);
            this.labelPrecio.TabIndex = 12;
            this.labelPrecio.Text = "Precio:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(451, 461);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(133, 29);
            this.CancelarButton.TabIndex = 13;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrearArticuloButton
            // 
            this.CrearArticuloButton.Location = new System.Drawing.Point(244, 461);
            this.CrearArticuloButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CrearArticuloButton.Name = "CrearArticuloButton";
            this.CrearArticuloButton.Size = new System.Drawing.Size(133, 29);
            this.CrearArticuloButton.TabIndex = 14;
            this.CrearArticuloButton.Text = "Aceptar";
            this.CrearArticuloButton.UseVisualStyleBackColor = true;
            this.CrearArticuloButton.Click += new System.EventHandler(this.CrearArticuloButton_Click);
            // 
            // ImagenTextBox
            // 
            this.ImagenTextBox.Location = new System.Drawing.Point(174, 378);
            this.ImagenTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImagenTextBox.Name = "ImagenTextBox";
            this.ImagenTextBox.Size = new System.Drawing.Size(235, 26);
            this.ImagenTextBox.TabIndex = 15;
            this.ImagenTextBox.Leave += new System.EventHandler(this.ImagenTextBox_Leave);
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Location = new System.Drawing.Point(87, 386);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(67, 20);
            this.labelImagen.TabIndex = 16;
            this.labelImagen.Text = "Imagen:";
            // 
            // pbImagenCrear
            // 
            this.pbImagenCrear.Location = new System.Drawing.Point(468, 62);
            this.pbImagenCrear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbImagenCrear.Name = "pbImagenCrear";
            this.pbImagenCrear.Size = new System.Drawing.Size(410, 342);
            this.pbImagenCrear.TabIndex = 17;
            this.pbImagenCrear.TabStop = false;
            // 
            // buttonAgregarImagen
            // 
            this.buttonAgregarImagen.Location = new System.Drawing.Point(416, 378);
            this.buttonAgregarImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAgregarImagen.Name = "buttonAgregarImagen";
            this.buttonAgregarImagen.Size = new System.Drawing.Size(32, 29);
            this.buttonAgregarImagen.TabIndex = 18;
            this.buttonAgregarImagen.Text = "+";
            this.buttonAgregarImagen.UseVisualStyleBackColor = true;
            this.buttonAgregarImagen.Click += new System.EventHandler(this.buttonAgregarImagen_Click);
            // 
            // ArticuloCrearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 539);
            this.Controls.Add(this.buttonAgregarImagen);
            this.Controls.Add(this.pbImagenCrear);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.ImagenTextBox);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ArticuloCrearForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Articulo:";
            this.Load += new System.EventHandler(this.ArticuloCrearForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCrear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox ImagenTextBox;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.PictureBox pbImagenCrear;
        private System.Windows.Forms.Button buttonAgregarImagen;
    }
}