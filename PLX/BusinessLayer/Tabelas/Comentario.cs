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
        [Required]
        public string Conteudo { get; set; }
        [Required]
        public virtual Usuario Usuario { get; set; }
        [Required]
        public virtual Anuncio Anuncio { get; set; }
    }
}
