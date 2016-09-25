using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class AnuncioDto
    {
        public String Descricao { get; set; }
        public String Titulo { get; set; }
        public Double Preco { get; set; }
        public String Imagem { get; set; }
        public int Status { get; set; }
        public UsuarioDto UsuarioDto { get; set; }
        public List<ComentarioDto> ComentariosDto { get; set; }
        public CategoriaDto Categoria { get; set; }
    }
}
