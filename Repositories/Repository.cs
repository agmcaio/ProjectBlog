using Dapper.Contrib.Extensions;
using DapperProjectBlog.Models;
using Microsoft.Data.SqlClient;
using System.Reflection;

namespace DapperProjectBlog.Repositories
{
    public class Repository<TModel> where TModel : class
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection)
        {
            _connection = connection;  
        }

        public IEnumerable<TModel> Get()
        {
            return _connection.GetAll<TModel>();
        }

        public TModel Get(int id)
        {
            return _connection.Get<TModel>(id);
        }

        public void Insert(TModel model)
        {
            _connection.Insert<TModel>(model);
        }

        public void Update(TModel model)
        {
            PropertyInfo idProperty = typeof(TModel).GetProperty("Id");
            int id = (int)idProperty.GetValue(model);

            if(id != 0)
                _connection.Update<TModel>(model);
        }

        public void Delete(TModel model)
        {
            PropertyInfo idProperty = typeof(TModel).GetProperty("Id");
            int id = (int)idProperty.GetValue(model);

            if (id != 0)
            {
                _connection.Delete<TModel>(model);
            }
        }

        public void Delete(int id)
        {
            var role = _connection.Get<TModel>(id);
            _connection.Delete<TModel>(role);
        }
    }
}
