using DapperProjectBlog.Screens.CategoryScreens;

namespace DapperProjectBlog.Screens.TagScreens
{
    public static class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Tag Management");
            Console.WriteLine();
            Console.WriteLine("1 - Register tag");
            Console.WriteLine("2 - Update tag");
            Console.WriteLine("3 - List all tags");
            Console.WriteLine("4 - Delete tag");
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
