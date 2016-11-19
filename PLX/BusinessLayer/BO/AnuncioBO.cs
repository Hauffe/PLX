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
    internal class AnuncioBO : BaseBO
    {
        internal AnuncioBO(SqlServerDao dao) : base(dao) { }

        public void SalvarAnuncio(AnuncioDto anuncio)
        {
            var tabela = AutoMapper.Mapper.Map<Anuncio>(anuncio);
            tabela.DataAtualizacao = DateTime.Now;
            tabela.DataCriacao = DateTime.Now;
            Dao.Inserir(tabela);
        }

        public void AtualizarAnuncio(AnuncioDto anuncio)
        {
            var tabela = AutoMapper.Mapper.Map<Anuncio>(anuncio);
            tabela.DataAtualizacao = DateTime.Now;
            Dao.Atualizar(tabela);
        }

        public void DeletarAnuncio(AnuncioDto anuncio)
        {
            var tabela = AutoMapper.Mapper.Map<Anuncio>(anuncio);
            Dao.Excluir(tabela);
        }

        public List<AnuncioDto> BuscarTodos()
        {
            return AutoMapper.Mapper.Map<List<AnuncioDto>>(Dao.Listar<Anuncio>());
        }

        public List<AnuncioDto> BuscarPorTitulo(string titulo)
        {
            var lista = Dao.Buscar<Anuncio>(a => a.Titulo.Contains(titulo));
            return AutoMapper.Mapper.Map<List<AnuncioDto>>(lista);
        }

        public AnuncioDto BuscarPorId(int id)
        {
            var anuncio = Dao.Buscar<Anuncio>(a => a.Id.Equals(id)).FirstOrDefault();
            return AutoMapper.Mapper.Map<AnuncioDto>(anuncio);
        }
    }
}
