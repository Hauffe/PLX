using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class CategoriaDto
    {
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public List<AnuncioDto> AnunciosDto { get; set; }
        public List<CategoriaDto> CategoriasDto { get; set; }
    }
}
