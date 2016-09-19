using DataLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class Avaliacao : Base
    {
        public DateTime Data { get; set; }
        public Double Nota { get; set; }
        public Usuario Ususario { get; set; }
    }
}
