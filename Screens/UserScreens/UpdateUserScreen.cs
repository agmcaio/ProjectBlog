using DapperProjectBlog.Models;
using DapperProjectBlog.Repositories;

namespace DapperProjectBlog.Screens.UserScreens
{
    public static class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("UPDATE USER:");
            Update();
        }

        private static void Update()
        {
            var user = new User();

            Console.WriteLine("Enter user ID will be updated: ");
            user.Id = int.Parse(Console.ReadLine());

            Console.WriteLine($"This is the user:");
            ReadUserById(user.Id);
            Console.WriteLine();

            Console.WriteLine($"Enter do you want to change:");
            Console.WriteLine("Name:");
            user.Name = Console.ReadLine();

            Console.WriteLine("Email:");
            user.Email = Console.ReadLine();

            Console.WriteLine("Password:");
            user.PasswordHash = Console.ReadLine();

            Console.WriteLine("Bio:");
            user.Bio = Console.ReadLine();

            Console.WriteLine("Image:");
            user.Image = Console.ReadLine();

            Console.WriteLine("Slug:");
            user.Slug = Console.ReadLine();

            var repository = new Repository<User>();
            repository.Update(user);
            Console.WriteLine();
            Console.WriteLine("Completed update!");
        }

        private static void ReadUserById(int id)
        {
            var repository = new Repository<User>();
            var user = repository.Get(id);
            Console.WriteLine($"{user.Id} - {user.Name}, {user.Email}, {user.PasswordHash}, {user.Bio}, {user.Image}, {user.Slug}");

        }
    }
}
