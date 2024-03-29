﻿using DapperProjectBlog.Screens.CategoryScreens;
using DapperProjectBlog.Screens.PostScreens;
using DapperProjectBlog.Screens.RoleScreens;
using DapperProjectBlog.Screens.UserScreen;

namespace DapperProjectBlog.Screens
{
    public static class MenuScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("===== MY BLOG =====");
            Console.WriteLine("Choose one option:");
            Console.WriteLine("1 - User Management");
            Console.WriteLine("2 - Role Management");
            Console.WriteLine("3 - Category Management");
            Console.WriteLine("4 - Tag Management");
            Console.WriteLine("5 - Post Management");
            Console.WriteLine("6 - Link role/user");
            Console.WriteLine("7 - Link post/tag");
            Console.WriteLine("0 - Report");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 2:
                    MenuRoleScreen.Load();
                    break;
                case 3:
                    MenuCategoryScreen.Load();
                    break;
                case 4:
                    MenuCategoryScreen.Load();
                    break;
                case 5:
                    MenuPostScreen.Load();
                    break;
                case 0:
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}
