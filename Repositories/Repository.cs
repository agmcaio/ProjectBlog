using Dapper.Contrib.Extensions;
using DapperProjectBlog.Models;
using Microsoft.Data.SqlClient;
using System.Reflection;

namespace DapperProjectBlog.Repositories
{
    public class Repository<TModel> where TModel : class
    {
        public IEnumerable<TModel> Get()
        {
            return Database.Connection.GetAll<TModel>();
        }

        public TModel Get(int id)
        {
            return Database.Connection.Get<TModel>(id);
        }

        public void Insert(TModel model)
        {
            Database.Connection.Insert<TModel>(model);
        }

        public void Update(TModel model)
        {
            PropertyInfo idProperty = typeof(TModel).GetProperty("Id");
            int id = (int)idProperty.GetValue(model);

            if(id != 0)
                Database.Connection.Update<TModel>(model);
        }

        public void Delete(TModel model)
        {
            PropertyInfo idProperty = typeof(TModel).GetProperty("Id");
            int id = (int)idProperty.GetValue(model);

            if (id != 0)
            {
                Database.Connection.Delete<TModel>(model);
            }
        }

        public void Delete(int id)
        {
            var role = Database.Connection.Get<TModel>(id);
            Database.Connection.Delete<TModel>(role);
        }
    }
}
