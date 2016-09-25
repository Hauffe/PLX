using DataLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Tabelas
{
    internal class Anuncio : Base
    {

        public String Descricao { get; set; }
        [Required]
        public String Titulo { get; set; }
        [Required]
        public Double Preco { get; set; }
        public String Imagem { get; set; }
        public int Status { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual List<Comentario> Comentarios { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
