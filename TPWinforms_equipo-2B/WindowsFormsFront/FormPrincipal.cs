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
                CategoriaNegocio negocioCategoria = new CategoriaNegocio();
                listaCategorias = negocioCategoria.listarCategorias();
                dgvCategorias.DataSource = listaCategorias;

                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                listaArticulos = articuloNegocio.ListarArticulos();
                dgvArticulos.DataSource = listaArticulos;


                MarcaNegocio marcaNegocio = new MarcaNegocio();
                listaMarcas = marcaNegocio.listarMarcas();
                dgvMarcas.DataSource = listaMarcas;

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
    }
}
