using DataLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class Categoria : Base
    {
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public virtual List<Anuncio> Anuncios { get; set; }
        public virtual List<Categoria> Categorias{ get; set; }
    }
}
