using SqlSugar;
using System.Collections.Generic;

namespace Getech.EAP.Entity.DBEntities.EntityManger
{
    public class EAPDBModel<T> : SimpleClient<T> where T : class, new()
    {
        public EAPDBModel(SqlSugarClient context) : base(context)
        {

        }
        //查询DB
        public List<T> ViewByids(dynamic[] ids)
        {
            return Context.Queryable<T>().In(ids).ToList();
        }
        //删除DB
        public int DeleteByids(dynamic[] ids)
        {
            return Context.Deleteable<T>().In(ids).ExecuteCommand();
        }

        //更新DB
        public int UpdateTableByids(dynamic[] ids)
        {
            return Context.Updateable<T>().ExecuteCommand();
        }
        //插入DB
        //public int InsertByids(dynamic[] ids)
        //{
        //    return Context.Insertable(List<T>).ExecuteCommand();
        //}
    }
}
