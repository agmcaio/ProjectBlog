using DapperProjectBlog.Screens.TagScreens;

namespace DapperProjectBlog.Screens.CategoryScreens
{
    public static class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Category Management");
            Console.WriteLine();
            Console.WriteLine("1 - Register category");
            Console.WriteLine("2 - Update category");
            Console.WriteLine("3 - List all category");
            Console.WriteLine("4 - Delete post");
            Console.WriteLine("0 - Back");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateTagScreen.Load();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Option Invalid!");
                    Console.ReadLine();
                    Load();
                    break;
            }
        }
    }
}
