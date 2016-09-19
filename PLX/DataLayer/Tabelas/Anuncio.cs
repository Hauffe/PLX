using DataLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class Anuncio : Base
    {
        public DateTime Data { get; set; }
        public String Descricao { get; set; }
        public String Titulo { get; set; }
        public Double Preco { get; set; }
        public String Imagem { get; set; }
        public int Status { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual List<Comentario> Comentarios { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
