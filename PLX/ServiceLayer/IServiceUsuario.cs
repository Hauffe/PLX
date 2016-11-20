using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceUsuario" in both code and config file together.
    [ServiceContract]
    public interface IServiceUsuario
    {
        [OperationContract]
        void SalvarUsuario(string nome, string email, string senha, string contato, int telefone);
    }
}
