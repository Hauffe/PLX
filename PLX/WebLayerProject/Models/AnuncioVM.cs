using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLayerProject.Models
{
    public class AnuncioVM
    {
        public String Descricao { get; set; }
        public String Titulo { get; set; }
        public Double Preco { get; set; }
        public String Imagem { get; set; }
        public int Status { get; set; }
        public UsuarioVM UsuarioVM { get; set; }
        public List<ComentarioVM> ComentariosVM { get; set; }
        public CategoriaVM CategoriaVM { get; set; }
    }
}
