using BusinessLayer.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceUsuario" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceUsuario.svc or ServiceUsuario.svc.cs at the Solution Explorer and start debugging.
    public class ServiceUsuario : IServiceUsuario
    {
        public void SalvarUsuario(string nome, string email, string senha, string contato, int telefone)
        {
            using (UsuarioFacade facade = new UsuarioFacade())
            {
                facade.SalvarUsuario(nome, email, senha, contato, telefone);
            }
        }
    }
}
