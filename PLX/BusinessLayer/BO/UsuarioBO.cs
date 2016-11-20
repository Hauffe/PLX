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
    internal class UsuarioBO : BaseBO

    {
        internal UsuarioBO(SqlServerDao dao) : base(dao) { }

        public void SalvarUsuario(UsuarioDto usuario)
        {
            var tabela = AutoMapper.Mapper.Map<Usuario>(usuario);
            tabela.DataAtualizacao = DateTime.Now;
            tabela.DataCriacao = DateTime.Now;
            Dao.Inserir(tabela);
        }

        public void AtualizarUsuario(UsuarioDto usuario)
        {
            var tabela = AutoMapper.Mapper.Map<Usuario>(usuario);
            tabela.DataAtualizacao = DateTime.Now;
            Dao.Atualizar(tabela);
        }

        public void DeletarUsuario(UsuarioDto usuario)
        {
            var tabela = AutoMapper.Mapper.Map<Usuario>(usuario);
            Dao.Excluir(tabela);
        }

        public List<UsuarioDto> BuscarTodos()
        {
            return AutoMapper.Mapper.Map<List<UsuarioDto>>(Dao.Listar<Usuario>());
        }

        public UsuarioDto BuscarPorId(int id)
        {
            var usuario = Dao.Buscar<Usuario>(a => a.Id.Equals(id)).FirstOrDefault();
            return AutoMapper.Mapper.Map<UsuarioDto>(usuario);
        }
    }
}