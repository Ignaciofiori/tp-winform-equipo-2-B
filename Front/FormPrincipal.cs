using modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Front
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();

            articulo.Nombre = "SOY EL NOMBRE DEL PRIMER ARTICULO, PRUEBA DE REFERENCIAS ENTRE PROYECTOS EXITOSA";
            MessageBox.Show(articulo.Nombre);

        }
    }
}
