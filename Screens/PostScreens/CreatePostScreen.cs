using DapperProjectBlog.Models;

namespace DapperProjectBlog.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("ENTER YOUR DATA FOR POST:");
            Create();
        }

        public static void Create() 
        {
            var post = new Post();

            Console.WriteLine("Category ID:");
            post.CategoryId

            Console.WriteLine("Title:");
            post.Title = Console.ReadLine();

            Console.WriteLine("Summary:");
            post.Summary = Console.ReadLine();
            
            Console.WriteLine("Body:");
            post.Body = Console.ReadLine();
            
            Console.WriteLine("Slug:");
            post.Slug = Console.ReadLine();

            post.CreateDate = DateTime.Now;
            post.LastUpdateDate = DateTime.Now;

            Console.WriteLine();
        }
    }
}
