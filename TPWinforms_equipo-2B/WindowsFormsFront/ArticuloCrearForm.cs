using modelo;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsFront
{
    public partial class ArticuloCrearForm : Form
    {
        private Articulo articulo = null;

        private OpenFileDialog archivo = null;

        private string UrlImagen = null;
        public ArticuloCrearForm()
        {
            InitializeComponent();
        }

        public ArticuloCrearForm(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ArticuloCrearForm_Load(object sender, EventArgs e)
        {
            //cargo combo box con Categorias
            CategoriaNegocio catnegocio = new CategoriaNegocio();
            List<Categoria> listaCategorias = catnegocio.listarCategorias();
            CategoriaArticuloComboBox.DataSource = listaCategorias;
            CategoriaArticuloComboBox.DisplayMember = "Descripcion";
            CategoriaArticuloComboBox.ValueMember = "Id";
            //cargo combo box con Marcas
            MarcaNegocio marNegocio = new MarcaNegocio();
            List<Marca> listaMarcas = marNegocio.listarMarcas();
            MarcaArticuloComboBox.DataSource = listaMarcas;
            MarcaArticuloComboBox.DisplayMember = "Descripcion";
            MarcaArticuloComboBox.ValueMember = "Id";

           // CategoriaArticuloComboBox.DataSource = listaCategorias;

            if (articulo != null)
            {
                //Text = "Modificar Articulo";
                CodArticuloTextBox.Text = articulo.CodigoArticulo;
                NombreArticuloTextBox.Text = articulo.Nombre;
                DescripcionArticuloTextBox.Text = articulo.Descripcion;
                PrecioNumericUpDown.Value = articulo.Precio;
                CategoriaArticuloComboBox.SelectedValue = articulo.Categoria.Id;
                MarcaArticuloComboBox.SelectedValue = articulo.Marca.Id;
                //CrearArticuloButton.Text = "Modificar";
                ///Falta modificar cambiar imagen
                CategoriaArticuloComboBox.SelectedValue = articulo.Categoria.Id;
                MarcaArticuloComboBox.SelectedValue = articulo.Marca.Id;

            }

        }

        public void cargarImagen(string urlImagen)
        {
            try
            {
                pbImagenCrear.Load(urlImagen);
            }
            catch (Exception ex)
            {

                pbImagenCrear.Load("https://dummyimage.com/300x300/cccccc/000000.png&text=Imagen+no+disponible");
            }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearArticuloButton_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocioArticulo = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            Articulo articuloNuevo = new Articulo();
            try
            {

                    articuloNuevo.CodigoArticulo = CodArticuloTextBox.Text;
                    articuloNuevo.Nombre = NombreArticuloTextBox.Text;
                    articuloNuevo.Descripcion = DescripcionArticuloTextBox.Text;
                    articuloNuevo.Precio = PrecioNumericUpDown.Value;
                    articuloNuevo.Marca = (Marca)MarcaArticuloComboBox.SelectedItem;
                    articuloNuevo.Categoria = (Categoria)CategoriaArticuloComboBox.SelectedItem;
                    
                    UrlImagen = ImagenTextBox.Text;



                if (archivo != null && !(ImagenTextBox.Text.ToUpper().Contains("HTTP")))
                {
                    //guardo imagen
                    string carpeta = ConfigurationManager.AppSettings["images-folder"];
                    string nombre = Path.GetFileNameWithoutExtension(archivo.SafeFileName);
                    string extension = Path.GetExtension(archivo.SafeFileName);
                    string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

                    string destino = Path.Combine(carpeta, nombre + "_" + timestamp + extension);

                    File.Copy(archivo.FileName, destino);
                }

                if (articulo!= null)
                {   
                    negocioArticulo.modificarArticulo(articulo);
                    MessageBox.Show("Modificado correctamente!!");
                }
                else
                {
                    int idArticuloGenerado = negocioArticulo.agregarArticulo(articuloNuevo);
                    imagenNegocio.AgregarImagen(idArticuloGenerado, UrlImagen);
                    MessageBox.Show("Agregado correct   amente!!");
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            { 
                ImagenTextBox.Text= archivo.FileName;
                cargarImagen(archivo.FileName);

                
            }
        }

        private void ImagenTextBox_Leave(object sender, EventArgs e)
        {
            cargarImagen(ImagenTextBox.Text);
        }
    }
}
