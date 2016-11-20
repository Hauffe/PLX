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
    public class AnuncioFacade : BaseFacade
    {

        private AnuncioBO anuncioBo;
        private UsuarioBO usuarioBO;
        private CategoriaBO categoriaBO;
        private SqlServerDao dao;

        public AnuncioFacade()
        {
            dao = new SqlServerDao();
            anuncioBo = new AnuncioBO(dao);
            usuarioBO = new UsuarioBO(dao);
            categoriaBO = new CategoriaBO(dao);
        }

        public void SalvarAnuncio(string titulo, double preco, int idUsuario, int idCategoria)
        {
            AnuncioDto a = new AnuncioDto();

            UsuarioDto u = new UsuarioDto();
            u = usuarioBO.BuscarPorId(idUsuario);

            CategoriaDto cat = new CategoriaDto();
            cat = categoriaBO.BuscarPorId(idCategoria);

            a.CategoriaDto = cat;
            a.UsuarioDto = u;

            a.Titulo = titulo;
            a.Preco = preco;
            
            anuncioBo.SalvarAnuncio(a);
        }
    }
}
