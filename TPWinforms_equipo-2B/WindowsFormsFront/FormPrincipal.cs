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
        
        private List<Articulo> listaArticulos;
        private List<Imagen> imagenesArticuloSeleccionado;
        private int indiceImagen = 0;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.ListarArticulos();
                dgvArticulos.DataSource = listaArticulos;
               
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
            try
            {


                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                listaArticulos = articuloNegocio.ListarArticulos();
                dgvArticulos.DataSource = listaArticulos;

                cboCampo.Items.Add("Id");
                cboCampo.Items.Add("Código");
                cboCampo.Items.Add("Nombre");
                cboCampo.Items.Add("Descripción");
                cboCampo.Items.Add("Precio");

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

            cargar();
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

            cargar();


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
                    cargar();
                    
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
            catch
            {

                pbPricinpalArticulos.Load("https://dummyimage.com/300x300/cccccc/000000.png&text=Imagen+no+disponible");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null) return;
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            imagenesArticuloSeleccionado = imagenNegocio.ListarImagenesPorArticulo(seleccionado.Id);
            indiceImagen = 0;

            if (imagenesArticuloSeleccionado.Count > 0)
            {
                string UrlImagenSeleccionada = imagenesArticuloSeleccionado[indiceImagen].ImagenURL;

                cargarImagen(UrlImagenSeleccionada);
            }
            else
            {
                cargarImagen("https://dummyimage.com/300x300/cccccc/000000.png&text=Imagen+no+disponible");
            }

        }

        private void pbPricinpalArticulos_Click(object sender, EventArgs e)
        {
            if (imagenesArticuloSeleccionado.Count == 0) return;
            indiceImagen ++;
            if(indiceImagen >= imagenesArticuloSeleccionado.Count)
            {
                indiceImagen = 0;
            }
            cargarImagen(imagenesArticuloSeleccionado[indiceImagen].ImagenURL);
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            cboCriterio.Items.Clear();

            if (opcion == "Id" || opcion == "Código")
            {
                cboCriterio.Items.Add("Igual a");
            }
            else if (opcion == "Nombre" || opcion == "Descripción")
            {
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
            else if (opcion == "Precio")
            {
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
        }


        private bool validarBuscar()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un campo!");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un criterio!");
                return true;
            }
            if (tboFiltro.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el filtro!");
                return true;
            }

            return false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarBuscar()) return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = tboFiltro.Text;
                dgvArticulos.DataSource = negocio.BuscarArticulo(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
