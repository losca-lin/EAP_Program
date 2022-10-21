using SqlSugar;
using System;
using System.Configuration;
using System.Reflection;
using Workbench.Contract.Log;

namespace Getech.EAP.Entity.DBEntities.EntityManger
{
    public class EAPDbContext : IDisposable
    {
        private static readonly Lazy<EAPDbContext> Lazy = new Lazy<EAPDbContext>(() => new EAPDbContext());
        public static EAPDbContext Current => Lazy.Value;

        protected static readonly ILogManager log = NLogManager.Logger;

        public static SqlSugarScope db1 = GetInstance();

        public static SqlSugarScope GetInstance()
        {
            var db = new SqlSugarScope(new ConnectionConfig()
            { 
                ConnectionString = ConfigurationManager.AppSettings["DbConstr"],
                DbType = DbType.SqlServer,
                InitKeyType = InitKeyType.Attribute,
                IsAutoCloseConnection = true
            });
            db.Aop.OnError = (exp) =>//执行SQL 错误事件
            {
                log.LogErrorWrite("DBService", "EAPDbContext", MethodBase.GetCurrentMethod().Name + "()", string.Format("{0}", exp));
            };
            db1 = db;
            return db;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
