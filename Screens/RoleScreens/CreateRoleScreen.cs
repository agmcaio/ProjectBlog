using DapperProjectBlog.Models;
using DapperProjectBlog.Repositories;

namespace DapperProjectBlog.Screens.RoleScreens
{
    public static class CreateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("ENTER YOUR DATA");
            Create();
        }

        private static void Create()
        {
            var role = new Role();

            Console.WriteLine("Name:");
            role.Name = Console.ReadLine()!;
            Console.WriteLine("Slug:");
            role.Slug = Console.ReadLine()!;

            var repository = new Repository<Role>();
            repository.Insert(role);
            Console.WriteLine("Completed registration!");
        }
    }
}
