using DapperProjectBlog.Screens.UserScreen;
using DapperProjectBlog.Screens.UserScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperProjectBlog.Screens.PostScreens
{
    public static class MenuPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Post Management");
            Console.WriteLine();
            Console.WriteLine("1 - Register post");
            Console.WriteLine("2 - Update post");
            Console.WriteLine("3 - list especif post");
            Console.WriteLine("4 - List all posts");
            Console.WriteLine("5 - Delete post");
            Console.WriteLine("0 - Back");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreatePostScreen.Load();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
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
