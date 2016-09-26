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
    internal class AvaliacaoBO : BaseBO
    {
        internal AvaliacaoBO(SqlServerDao dao) : base(dao) { }

        public void SalvarAvaliacao(AvaliacaoDto avaliacao)
        {
            var tabela = AutoMapper.Mapper.Map<Avaliacao>(avaliacao);
            tabela.DataAtualizacao = DateTime.Now;
            tabela.DataCriacao = DateTime.Now;
            Dao.Inserir(tabela);
        }

        public void AtualizarAvaliacao(AvaliacaoDto avaliacao)
        {
            var tabela = AutoMapper.Mapper.Map<Avaliacao>(avaliacao);
            tabela.DataAtualizacao = DateTime.Now;
            Dao.Atualizar(tabela);
        }

        public void DeletarAvaliacao(AvaliacaoDto avaliacao)
        {
            var tabela = AutoMapper.Mapper.Map<Avaliacao>(avaliacao);
            Dao.Excluir(tabela);
        }

        public List<AvaliacaoDto> BuscarTodos()
        {
            return AutoMapper.Mapper.Map<List<AvaliacaoDto>>(Dao.Listar<Avaliacao>());
        }

        public AvaliacaoDto BuscarPorId(int id)
        {
            var avaliacao = Dao.Buscar<Avaliacao>(a => a.Id.Equals(id)).FirstOrDefault();
            return AutoMapper.Mapper.Map<AvaliacaoDto>(avaliacao);
        }
    }
}

