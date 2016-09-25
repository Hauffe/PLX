using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DAO;
using BusinessLayer.DTO;
using BusinessLayer.Tabelas;

namespace BusinessLayer.BO
{
    internal class ComentarioBO : BaseBO
    {
        internal ComentarioBO(SqlServerDao dao) : base(dao) { }

        public void SalvarComentario(ComentarioDto comentario)
        {
            var tabela = AutoMapper.Mapper.Map<Comentario>(comentario);
            Dao.Inserir(tabela);
        }

        public void AtualizarComentario(ComentarioDto comentario)
        {
            var tabela = AutoMapper.Mapper.Map<Comentario>(comentario);
            Dao.Atualizar(tabela);
        }

        public void DeletarComentario(ComentarioDto comentario)
        {
            var tabela = AutoMapper.Mapper.Map<Comentario>(comentario);
            Dao.Excluir(tabela);
        }

        public List<ComentarioDto> BuscarTodos()
        {
            return AutoMapper.Mapper.Map<List<ComentarioDto>>(Dao.Listar<Comentario>());
        }

        public ComentarioDto BuscarPorId(int id)
        {
            var comentario = Dao.Buscar<Comentario>(a => a.Id.Equals(id)).FirstOrDefault();
            return AutoMapper.Mapper.Map<ComentarioDto>(comentario);
        }
    }
}
