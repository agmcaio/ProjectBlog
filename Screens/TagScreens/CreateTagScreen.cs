using DapperProjectBlog.Models;
using DapperProjectBlog.Repositories;

namespace DapperProjectBlog.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("ENTER YOUR DATA:");
            Create();
        }

        private static void Create()
        {
            var tag = new Tag();

            Console.WriteLine("Name:");
            tag.Name = Console.ReadLine();

            Console.WriteLine("Slug:");
            tag.Slug = Console.ReadLine();

            var repository = new Repository<Tag>();
            repository.Insert(tag);
            Console.WriteLine("Completed registration!");
        }
    }
}