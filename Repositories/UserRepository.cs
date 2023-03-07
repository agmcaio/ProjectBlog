using Dapper.Contrib.Extensions;
using DapperProjectBlog.Models;
using Microsoft.Data.SqlClient;

namespace DapperProjectBlog.Repositories
{
    public class UserRepository
    {
        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<User> Get()
        {
            return _connection.GetAll<User>();
        }

        public User Get(int id)
        {
            return _connection.Get<User>(id);
        }

        public void Insert(User user)
        {
            user.Id = 0; // Pra não ocorrer de colocar um id que já exista
            _connection.Insert<User>(user);
        }

        public void Update(User user)
        {
            if (user.Id != 0) 
            {
                _connection.Insert<User>(user);
            }
        }

        public void Delete(User user)
        {
            if (user.Id != 0)
            {
                _connection.Delete<User>(user);
            }
        }

        public void Delete(int id)
        {
            if (id != 0)
                return; // sair da função

            var user = _connection.Get<User>(id);
            _connection.Delete<User>(user);
        }
    }
}
