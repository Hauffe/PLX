﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DAO;
using BusinessLayer.DTO;
using BusinessLayer.Tabelas;

namespace BusinessLayer.BO
{
    internal class CategoriaBO : BaseBO
    {
        internal CategoriaBO(SqlServerDao dao) : base(dao) { }

        public void SalvarCategoria(CategoriaDto categoria)
        {
            var tabela = AutoMapper.Mapper.Map<Categoria>(categoria);
            tabela.DataAtualizacao = DateTime.Now;
            tabela.DataCriacao = DateTime.Now;
            //tabela.Anuncios = new List<Anuncio>();
            //tabela.Categorias = new List<Categoria>();
            Dao.Inserir(tabela);

        }

        public void AtualizarCategoria(CategoriaDto categoria)
        {
            var tabela = AutoMapper.Mapper.Map<Categoria>(categoria);
            tabela.DataAtualizacao = DateTime.Now;
            Dao.Atualizar(tabela);
        }

        public void DeletarCategoria(CategoriaDto categoria)
        {
            var tabela = AutoMapper.Mapper.Map<Categoria>(categoria);
            Dao.Excluir(tabela);
        }

        public List<CategoriaDto> BuscarTodos()
        {
            var ret = Dao.Listar<Categoria>();
            return AutoMapper.Mapper.Map<List<CategoriaDto>>(ret);
        }

        public CategoriaDto BuscarPorId(int id)
        {
            var categoria = Dao.Buscar<Categoria>(a => a.Id.Equals(id)).FirstOrDefault();
            return AutoMapper.Mapper.Map<CategoriaDto>(categoria);
        }
    }
}
