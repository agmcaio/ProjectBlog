using DapperProjectBlog.Screens.UserScreen;
using DapperProjectBlog.Screens.UserScreens;

namespace DapperProjectBlog.Screens.RoleScreens
{
    public static class MenuRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Role Management");
            Console.WriteLine();
            Console.WriteLine("1 - Register role");
            Console.WriteLine("2 - Update role");
            Console.WriteLine("3 - List all role");
            Console.WriteLine("4 - Delete role");
            Console.WriteLine("0 - Back");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateRoleScreen.Load();
                    break;
                case 2:
                    break;
                case 3:
                    ListRoleScreen.Load();
                    break;
                case 5:
                    break;
                case 0:
                    MenuScreen.Load();
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
