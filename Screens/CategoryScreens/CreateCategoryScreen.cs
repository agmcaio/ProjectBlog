using DapperProjectBlog.Models;
using DapperProjectBlog.Repositories;

namespace DapperProjectBlog.Screens.CategoryScreens
{
    public static class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("ENTER YOUR DATA:");
            Create();
        }

        public static void Create()
        {
            var category = new Category();

            Console.WriteLine("Name:");
            category.Name = Console.ReadLine();

            Console.WriteLine("Slug:");
            category.Slug = Console.ReadLine();

            var repository = new Repository<Category>();
            repository.Insert(category);
            Console.WriteLine("Completed registration");
        }
    }
}
