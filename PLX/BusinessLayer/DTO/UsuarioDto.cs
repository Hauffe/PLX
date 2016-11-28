using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public List<AvaliacaoDto> AvaliacoesDto { get; set; }
        public List<ComentarioDto> ComentariosDto { get; set; }
        public List<AnuncioDto> AnunciosDto { get; set; }
    }
}
