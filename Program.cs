using Dapper.Contrib.Extensions;
using DapperProjectBlog.Models;
using DapperProjectBlog.Repositories;
using Microsoft.Data.SqlClient;

namespace DapperProjectBlog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=blog-project;User Id=sa;Password=santos2002;TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                ReadUsers(connection);
                ReadRoles(connection);
            }
        }

        // USER
        static void ReadUsers(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var users = repository.Get();

            foreach (var user in users)
                Console.WriteLine(user.Name);
        }

        static void ReadUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);

                Console.WriteLine(user.Name);
            }
        }

        static void CreateUser()
        {
            var user = new User()
            {
                // O id já é gerado;
                Bio = "Estudante de Tecnologia",
                Email = "igor@email.com",
                Image = "https://",
                Name = "Igor",
                PasswordHash = "HASH",
                Slug = "agmigor"
            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);
                Console.WriteLine("Cadastro realizado!");
            }
        }
   
        static void UpdateUser()
        {
            var user = new User()
            {
                Id = 2,
                Bio = "Desenvolvedor",
                Email = "igor@email.com",
                Image = "https://",
                Name = "Igor",
                PasswordHash = "HASH",
                Slug = "agmigor"
            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Update<User>(user);
                Console.WriteLine("Atualização Realizada!");
            }
        }
    
        static void DeleteUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(2); // Obtendo o usuário
                connection.Delete<User>(user); // Apagando usuário
                Console.WriteLine("Remoção Realizada!");
            }
        }

        // ROLE
        static void ReadRoles(SqlConnection connection)
        {
            var repository = new RoleRepository(connection);
            var roles = repository.Get();

            foreach (var role in roles)
                Console.WriteLine(role.Name);
        }
    }

}