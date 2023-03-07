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
                //ReadRoles(connection);
                //DeleteUser(connection);
                //CreateUser(connection);
                //UpdateUser(connection);
                //ReadUsers(connection);
            }
        }

        // USER
        static void ReadUsers(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var users = repository.Get();

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
                foreach(var role in user.Roles)
                    Console.WriteLine($" - {role.Name}");
            }
        }

        static void ReadUser(SqlConnection connection, int id)
        {
            var repository = new Repository<User>(connection);
            var user = repository.Get(id);
            Console.WriteLine(user.Name);
        }

        static void CreateUser(SqlConnection connection)
        {
            var user = new User()
            {
                // O id já é gerado;
                Bio = "Desenvolvedor Backend Junior",
                Email = "caio@email.com",
                Image = "https://",
                Name = "Caio",
                PasswordHash = "9191",
                Slug = "agmcaio"
            };

            var repository = new Repository<User>(connection);
            repository.Insert(user);
            Console.WriteLine("Cadastro realizado!");
        }
   
        static void UpdateUser(SqlConnection connection, int id)
        {
            var user = new User()
            {
                Id = id,
                Bio = "Desenvolvedor Backend Junior",
                Email = "caio@email.com",
                Image = "https://",
                Name = "Caio Guilherme",
                PasswordHash = "9191",
                Slug = "agmcaio"
            };

            var repository = new Repository<User>(connection);
            repository.Update(user);
            Console.WriteLine("Atualização Realizada!");
        }
    
        static void DeleteUser(SqlConnection connection, int id)
        {
            var repository = new Repository<User>(connection);
            repository.Delete(id);
            Console.WriteLine("Remoção Realizada!");
        }

        // ROLE
        static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var roles = repository.Get();

            foreach (var role in roles)
                Console.WriteLine(role.Name);
        }

        static void ReadRole(SqlConnection connection, int id)
        {
            var repository = new Repository<Role>(connection);
            var role = repository.Get(id);
            Console.WriteLine($"{role.Name} - {role.Slug}");
        }

        static void CreateRole(SqlConnection connection)
        {
            var role = new Role()
            {
                Name = "Leitor",
                Slug = "leitor"
            };

            var repository = new Repository<Role>(connection);
            repository.Insert(role);
            Console.WriteLine("Cadastro Realizado!");
        }
    
        static void UpdateRole(SqlConnection connection, int id)
        {
            var role = new Role()
            {
                Id = id,
                Name = "Name",
                Slug = "Slug"
            };

            var repository = new Repository<Role>(connection);
            repository.Update(role);
            Console.WriteLine("Atualização realizada!");
        }

        static void DeleteRole(SqlConnection connection, int id)
        {
            var repository = new Repository<Role>(connection);
            repository.Delete(id);
            Console.WriteLine("Cadastro Removido!");
        }
    }

}