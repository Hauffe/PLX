using DataLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Tabelas
{
    internal class Comentario : Base
    {
        public string Conteudo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Anuncio Anuncio { get; set; }
    }
}
