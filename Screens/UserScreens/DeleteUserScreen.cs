using DapperProjectBlog.Models;
using DapperProjectBlog.Repositories;

namespace DapperProjectBlog.Screens.UserScreen
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Delete();
        }

        public static void Delete() 
        {
            Console.WriteLine("Enter user ID for delete:");
            var userId = int.Parse(Console.ReadLine());
            var repository = new Repository<User>();
            repository.Delete(userId);
            Console.WriteLine("Completed Delete!");
        }
    }
}