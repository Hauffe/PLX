using BusinessLayer.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLayer.DTO;

namespace ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceCategoria" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceCategoria.svc or ServiceCategoria.svc.cs at the Solution Explorer and start debugging.
    public class ServiceCategoria : IServiceCategoria
    {
        public CategoriaDto buscarPorId(int id)
        {
            using (CategoriaFacade facade = new CategoriaFacade())
            {
                return facade.BuscarPorId(id);
            }
        }

        public List<CategoriaDto> ListarTodos()
        {
            using (CategoriaFacade facade = new CategoriaFacade())
            {
                return facade.BuscarTodos();
            }
        }

        public void SalvarCategoria(string Nome, string Descricao)
        {
            using (CategoriaFacade facade = new CategoriaFacade())
            {
                facade.SalvarCategoria(Nome, Descricao);
            }
        }
    }
}
