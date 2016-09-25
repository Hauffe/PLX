﻿using DataLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Tabelas
{
    internal class Avaliacao : Base
    {
        public Double Nota { get; set; }
        public Usuario Usuario { get; set; }
    }
}
