using DapperProjectBlog.Repositories;
using DapperProjectBlog.Screens.UserScreens;

namespace DapperProjectBlog.Screens.UserScreen
{
    public static class MenuUserScreen
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("User Management");
            Console.WriteLine();
            Console.WriteLine("1 - Register user");
            Console.WriteLine("2 - Update user");
            Console.WriteLine("3 - list especif user");
            Console.WriteLine("4 - List all users");
            Console.WriteLine("5 - Delete user");
            Console.WriteLine("0 - Back");
            Console.WriteLine( );
            var option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    CreateUserScreen.Load();
                    break;
                case 2:
                    UpdateUserScreen.Load();
                    break;
                case 3:
                    ListUserScreen.Load();
                    break;
                case 4:
                    ListUsersScreen.Load();
                    break;
                case 5:
                    DeleteUserScreen.Load();
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
