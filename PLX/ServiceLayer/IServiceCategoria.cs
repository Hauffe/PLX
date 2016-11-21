using BusinessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceCategoria" in both code and config file together.
    [ServiceContract]
    public interface IServiceCategoria
    {
        [OperationContract]
        void SalvarCategoria(string Nome, string Descricao);

        [OperationContract]
        List<CategoriaDto> ListarTodos();

        [OperationContract]
        CategoriaDto buscarPorId(int id);

    }
}
