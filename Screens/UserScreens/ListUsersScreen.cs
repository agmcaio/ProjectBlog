using DapperProjectBlog.Models;
using DapperProjectBlog.Repositories;

namespace DapperProjectBlog.Screens.UserScreens
{
    public static class ListUsersScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("List of users:");
            Console.WriteLine();
            Read();
        }

        private static void Read()
        {
            var repository = new UserRepository();
            var users = repository.GetWithRoles();

            foreach ( var user in users )
            {
                Console.Write($"{user.Id} - {user.Name}, {user.Email}, {user.Bio}, {user.Image}, {user.Slug}");
                foreach (var role in user.Roles)
                    if(user.Roles.Count > 0)
                        Console.WriteLine($", {role.Name}");
                    if(user.Roles.Count == 0)
                        Console.WriteLine(", NULL");
            }

        }
    }
}
