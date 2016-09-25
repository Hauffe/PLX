using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class UsuarioDto
    {
        public String Nome { get; set; }
        public String Contato { get; set; }
        public int Telefone { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public List<AvaliacaoDto> AvaliacoesDto { get; set; }
        public List<ComentarioDto> ComentariosDto { get; set; }
        public List<AnuncioDto> AnunciosDto { get; set; }
    }
}
