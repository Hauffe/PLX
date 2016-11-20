using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLayerProject.Models
{
    public class ComentarioVM
    {
        public String Conteudo { get; set; }
        public UsuarioVM UsuarioVM { get; set; }
        public AnuncioVM AnuncioVM { get; set; }
    }
}
