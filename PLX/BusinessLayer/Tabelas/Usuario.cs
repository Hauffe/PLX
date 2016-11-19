using DataLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Tabelas
{
    internal class Usuario : Base
    {
        public Usuario()
        {
            Comentarios = new List<Comentario>();
        }
        public string Nome { get; set; }
        public string Contato { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public virtual List<Avaliacao> Avaliacoes { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }
        public virtual List<Anuncio> Anuncios { get; set; }
    }
}
