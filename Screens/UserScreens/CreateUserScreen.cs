using DapperProjectBlog.Models;
using DapperProjectBlog.Repositories;

namespace DapperProjectBlog.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("ENTER YOUR DATA:");
            Create();
        }

        private static void Create() 
        {
            var user = new User();

            Console.WriteLine("Name:");
            user.Name = Console.ReadLine()!;
            Console.WriteLine("Email(example@email.com):");
            user.Email = Console.ReadLine()!;
            Console.WriteLine("Password:");
            user.PasswordHash = Console.ReadLine()!;
            Console.WriteLine("Bio:");
            user.Bio = Console.ReadLine()!;
            Console.WriteLine("Image Url:");
            user.Image = Console.ReadLine()!;
            Console.WriteLine("Slug");
            user.Slug = Console.ReadLine()!;

            var repository = new Repository<User>();
            repository.Insert(user);
            Console.WriteLine("Completed registration!");
        }
    }
}
