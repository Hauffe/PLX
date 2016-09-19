using DataLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class Comentario : Base
    {
        public DateTime Data { get; set; }
        public String Conteudo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Anuncio Anuncio { get; set; }
    }
}
