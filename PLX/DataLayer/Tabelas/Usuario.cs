using DataLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class Usuario : Base
    {
        public String Nome { get; set; }
        public String Contato { get; set; }
        public int Telefone { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public virtual List<Avaliacao> Avaliacoes { get; set; }
        public virtual List<Comentario> Comentarios { get; set; }
        public virtual List<Anuncio> Anuncios { get; set; }
    }
}
