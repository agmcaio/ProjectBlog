using DapperProjectBlog.Models;
using DapperProjectBlog.Repositories;

namespace DapperProjectBlog.Screens.RoleScreens
{
    public static class ListRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("List of roles");
            Read();
        }

        private static void Read()
        {
            var repository = new Repository<Role>();
            var role = repository.Get();
            foreach (var item in role)
            {
                Console.WriteLine($"{item.Id} - {item.Name}, {item.Slug}");
            }
        }
    }
}
