using BusinessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    [ServiceContract]
    public interface IServiceAnuncio
    {

        [OperationContract]
        void SalvarAnuncio(int IdUsuario, int IdCategoria, string Descricao, string Titulo, double Preco);

        [OperationContract]
        List<AnuncioDto> ListarTodos();

        [OperationContract]
        AnuncioDto buscarPorId(int id);

    }
}
