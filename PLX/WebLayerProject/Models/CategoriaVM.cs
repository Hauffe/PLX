using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLayerProject.Models
{
    public class CategoriaVM
    {
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public List<AnuncioVM> AnunciosVM { get; set; }
        public List<CategoriaVM> CategoriasVM { get; set; }
    }
}
