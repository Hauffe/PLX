using DataLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Tabelas
{
    internal class Avaliacao : Base
    {
        [Required]
        public Double Nota { get; set; }
        [Required]
        public virtual Usuario Usuario { get; set; }
    }
}
