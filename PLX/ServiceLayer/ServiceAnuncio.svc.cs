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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceAnuncio" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceAnuncio.svc or ServiceAnuncio.svc.cs at the Solution Explorer and start debugging.
    public class ServiceAnuncio : IServiceAnuncio
    {
        public AnuncioDto buscarPorId(int id)
        {
            using (AnuncioFacade facade = new AnuncioFacade())
            {
                return facade.BuscarPorId(id);
            }
        }

        public List<AnuncioDto> ListarTodos()
        {
            using (AnuncioFacade facade = new AnuncioFacade())
            {
                return facade.BuscarTodos();
            }
        }

        public void SalvarAnuncio(int IdUsuario, int IdCategoria, string Descricao, string Titulo, double Preco)
        {
            using (AnuncioFacade facade = new AnuncioFacade())
            {
                facade.SalvarAnuncio(Titulo, Preco, IdUsuario, IdCategoria);
            }
        }
    }
}
