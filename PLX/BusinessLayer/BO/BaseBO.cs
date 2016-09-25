using AutoMapper;
using BusinessLayer.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BO
{
    internal class BaseBO
    {
        public SqlServerDao Dao { get; set; }

        protected BaseBO(SqlServerDao dao)
        {
            Dao = dao;
        }

        static BaseBO()
        {
            // terminar de mapear os Dtos
            //Mapper.Initialize()
        }
    }
}
