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
    public class UsuarioFacade : BaseFacade
    {

        private UsuarioBO usuarioBo;
        private SqlServerDao dao;

        public UsuarioFacade()
        {
            dao = new SqlServerDao();
            usuarioBo = new UsuarioBO(dao);
        }

        public void SalvarUsuario(string nome, string email, string senha)
        {
            UsuarioDto a = new UsuarioDto();
            a.Nome = nome;
            a.Email = email;
            a.Senha = senha;
            usuarioBo.SalvarUsuario(a);
        }
    }
}
