using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLayerProject.Models
{
    public class UsuarioVM
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Contato { get; set; }
        public int Telefone { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public List<AvaliacaoVM> AvaliacoesVM { get; set; }
        public List<ComentarioVM> ComentariosVM { get; set; }
        public List<AnuncioVM> AnunciosVM { get; set; }
    }
}
