using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelo;
using negocio;

namespace WindowsFormsFront
{
    public partial class FormPrincipal : Form
    {
        private List<Categoria> listaCategorias;
        private List<Articulo> listaArticulos;
        private List<Marca> listaMarcas;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
            try
            {


                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                listaArticulos = articuloNegocio.ListarArticulos();
                dgvArticulos.DataSource = listaArticulos;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }  
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {   
            ArticuloCrearForm altaArticulo = new ArticuloCrearForm();
            altaArticulo.ShowDialog();
        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            ArticuloCrearForm modificar = new ArticuloCrearForm(seleccionado);
            modificar.ShowDialog();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta =  MessageBox.Show("Quiere eliminar el articulo seleccionado?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminarFisico(seleccionado.Id);
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void cargarImagen(string urlImagen)
        {
            try
            {
                pbPricinpalArticulos.Load(urlImagen);
            }
            catch (Exception ex)
            {

                pbPricinpalArticulos.Load("https://dummyimage.com/300x300/cccccc/000000.png&text=Imagen+no+disponible");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {   
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            List<Imagen> listaImagenes = new List<Imagen>();
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            listaImagenes = imagenNegocio.ListarImagenesPorArticulo(seleccionado.Id);

            if (listaImagenes.Count > 0)
            {
                string UrlImagenSeleccionada = listaImagenes[0].ImagenURL;

                cargarImagen(UrlImagenSeleccionada);
            }
            else
            {
                cargarImagen("https://dummyimage.com/300x300/cccccc/000000.png&text=Imagen+no+disponible");
            }

        }
    }
}
