using AutoMapper;
using BusinessLayer.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BO
{
    internal abstract class BaseBO
    {
        protected SqlServerDao Dao { get; set; }

        protected BaseBO(SqlServerDao dao)
        {
            Dao = dao;
        }

    }
}
