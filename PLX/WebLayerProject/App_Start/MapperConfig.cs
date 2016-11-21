using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLayerProject.Models;
using WebLayerProject.ServiceUsuario;

namespace WebLayerProject.App_Start
{
    public class MapperConfig
    {
        public static void InicializarMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AnuncioVM, AnuncioDto>();
                cfg.CreateMap<AnuncioDto, AnuncioVM>();
                cfg.CreateMap<AvaliacaoVM, AvaliacaoDto>();
                cfg.CreateMap<AvaliacaoDto, AvaliacaoVM>();
                cfg.CreateMap<CategoriaVM, CategoriaDto>();
                cfg.CreateMap<CategoriaDto, CategoriaVM>();
                cfg.CreateMap<ComentarioVM, ComentarioDto>();
                cfg.CreateMap<ComentarioDto, ComentarioVM>();
                cfg.CreateMap<UsuarioDto, UsuarioVM>();
                cfg.CreateMap<UsuarioVM, UsuarioDto>();
            });
        }
    }
}