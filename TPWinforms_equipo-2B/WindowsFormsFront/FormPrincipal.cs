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
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();
            listaCategorias = negocioCategoria.listarCategorias();
            dgvCategorias.DataSource = listaCategorias;
        }
    }
}
