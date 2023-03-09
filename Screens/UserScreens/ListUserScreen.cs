using DapperProjectBlog.Models;
using DapperProjectBlog.Repositories;

namespace DapperProjectBlog.Screens.UserScreen
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Read();
        }

        private static void Read()
        {
            Console.WriteLine("Enter User ID:");
            var userId = int.Parse(Console.ReadLine());

            var repository = new Repository<User>();
            var user = repository.Get(userId);
            Console.WriteLine($"{user.Id} - {user.Name}, {user.Email}, {user.Bio}, {user.Image}, {user.Slug}");
        }
    }
}