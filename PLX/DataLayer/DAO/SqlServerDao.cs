using DataLayer.Migrations;
using DataLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DAO
{
    public class SqlServerDao : DbContext
    {
        
        static SqlServerDao()
        {
            //configurar migraçao automatica
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SqlServerDao, Configuration>());
        }

        public SqlServerDao() : base("PLX")
        {
        }

        public List<TBase> Listar<TBase>() where TBase : Base
        {
            return Set<TBase>().ToList();
        }

        public List<TBase> Buscar<TBase>(Expression<Func<TBase, bool>> where) where TBase : Base
        {
            return Set<TBase>().Where(where).ToList();
        }

        public TBase BuscarPorId<TBase>(int id) where TBase : Base
        {
            return Set<TBase>().FirstOrDefault(b => b.Id == id);
        }

        public List<TBase> BuscarComPaginacao<TBase>(Expression<Func<TBase, bool>> where, int take, int skip) where TBase : Base
        {
            return Set<TBase>().Where(where).Take(take).OrderBy(p => p.Id).Skip(skip).ToList();
        }

        public void Inserir<TBase>(TBase obj) where TBase : Base
        {
            Set<TBase>().Add(obj);
            SaveChanges();
        }

        public void Atualizar<TBase>(TBase obj) where TBase : Base
        {
            SaveChanges();
        }

        public void Excluir<TBase>(TBase obj) where TBase : Base
        {
            Set<TBase>().Remove(obj);
            SaveChanges();
        }
    }
}
