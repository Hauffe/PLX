using BusinessLayer.BO;
using BusinessLayer.DAO;
using BusinessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Facades
{
    public class CategoriaFacade : BaseFacade
    {
        private CategoriaBO categoriaBo;
        private SqlServerDao dao;

        public CategoriaFacade()
        {
            dao = new SqlServerDao();
            categoriaBo = new CategoriaBO(dao);
        }

        public void SalvarCategoria(string nome, string descricao)
        {
            CategoriaDto c = new CategoriaDto();
            c.Nome = nome;
            c.Descricao = descricao;

            categoriaBo.SalvarCategoria(c);
        }

        public List<CategoriaDto> BuscarTodos()
        {
            return categoriaBo.BuscarTodos();
        }

        public CategoriaDto BuscarPorId(int id)
        {
            return categoriaBo.BuscarPorId(id);
        }


    }
}
