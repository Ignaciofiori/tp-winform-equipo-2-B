using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Articulo
    {
        public int CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        //Marca class Marca
        public int IdMarca { get; set; }
        public Marca Marca { get; set; }

        //Categoria class Categoria
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }

        //Imagen class Imagen
        public List<Imagen> Imagenes { get; set; }
    }
}