using modelo;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFront
{
    public partial class FormDetalleArticulo : Form
    {
        public FormDetalleArticulo()
        {
            InitializeComponent();
        }

        public FormDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();

            txtId.Text = articulo.Id.ToString();
            txtCodigo.Text = articulo.CodigoArticulo;
            txtNombre.Text = articulo.Nombre;
            txtDescripcion.Text = articulo.Descripcion;
            txtPrecio.Text = articulo.Precio.ToString("C");
            txtMarcaDetalle.Text = articulo.Marca.Descripcion;
            txtCategoria.Text = articulo.Categoria.Descripcion;
            try
            {
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                string urlImagen = imagenNegocio.ListarImagenesPorArticulo(articulo.Id).FirstOrDefault()?.ImagenURL;

                if (!string.IsNullOrEmpty(urlImagen))
                {
                    picImagen.Load(urlImagen);
                }
            }
            catch (Exception ex)
            {
                picImagen.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Solid_black.svg/2048px-Solid_black.svg.png");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
