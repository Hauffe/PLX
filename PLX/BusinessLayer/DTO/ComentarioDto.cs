using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class ComentarioDto
    {
        public String Conteudo { get; set; }
        public UsuarioDto UsuarioDto { get; set; }
        public AnuncioDto AnuncioDto { get; set; }
    }
}
