using AutoMapper;
using BusinessLayer.DAO;
using BusinessLayer.DTO;
using BusinessLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BO
{
    internal abstract class BaseBO
    {
        protected SqlServerDao Dao { get; set; }

        protected BaseBO(SqlServerDao dao)
        {
            Dao = dao;
        }

        static BaseBO()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Anuncio, AnuncioDto>();
                cfg.CreateMap<AnuncioDto, Anuncio>();
                cfg.CreateMap<Avaliacao, AvaliacaoDto>();
                cfg.CreateMap<AvaliacaoDto, Avaliacao>();
                cfg.CreateMap<Categoria, CategoriaDto>();
                cfg.CreateMap<CategoriaDto, Categoria>();
                cfg.CreateMap<Comentario, ComentarioDto>();
                cfg.CreateMap<ComentarioDto, Comentario>();
                cfg.CreateMap<Usuario, UsuarioDto>();
                cfg.CreateMap<UsuarioDto, Usuario>();
            });
        }
    }
}
