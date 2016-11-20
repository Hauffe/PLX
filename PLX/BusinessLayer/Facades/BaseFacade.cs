using AutoMapper;
using BusinessLayer.DAO;
using BusinessLayer.Tabelas;
using BusinessLayer.DTO;
using log4net;
using log4net.Config;
using System;
using System.IO;

namespace BusinessLayer.Facades
{
    public abstract class BaseFacade : IDisposable
    {
        internal SqlServerDao Dao { get; set; }

        //Usado para logar informacoes de falha da aplicacao
        protected static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static BaseFacade()
        {
            #region Log4Net

            XmlConfigurator.Configure(new FileInfo("Log.config"));

            #endregion

            #region  Inicializar automapper

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
                cfg.CreateMap<UsuarioDto, Usuario>();
                cfg.CreateMap<Usuario, UsuarioDto>();
            });

            #endregion
        }

        public BaseFacade()
        {
            Dao = new SqlServerDao();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (Dao != null) Dao.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~PessoaFacade() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
