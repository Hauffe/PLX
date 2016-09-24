using BusinessLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DAO
{
    class SqlServerDao : DataLayer.DAO.SqlServerDao
    {
        public DbSet<Anuncio> DbSetAnuncio { get; set; }
        public DbSet<Categoria> DbSetCategoria { get; set; }
        public DbSet<Comentario> DbSetComentario { get; set; }
        public DbSet<Usuario> DbSetUsuario { get; set; }
        public DbSet<Avaliacao> DbSetAvaliacao { get; set; }
    }
}
