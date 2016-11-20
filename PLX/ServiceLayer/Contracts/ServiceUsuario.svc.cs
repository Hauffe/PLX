using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLayer.DTO;
using BusinessLayer.Facades;

namespace ServiceLayer
{

    public class ServicePessoa : IServiceUsuario
    {
        public UsuarioDto SalvarUsuario(string nome, string email, string senha)
        {
            using (UsuarioFacade facade = new UsuarioFacade())
            {
                facade.SalvarUsuario(nome, email, senha);
                return null;
            }
        }
    }
}
