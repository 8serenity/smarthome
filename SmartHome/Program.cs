using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller MainContr = new Controller();

            int choice;

            Console.WriteLine("Добро пожаловать. Выберите действие:");
            Console.WriteLine("1. Вход");
            Console.WriteLine("2. Создать пользователя");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите имя");
                        string tempName = Console.ReadLine();
                        foreach(User user in MainContr.UserList)
                        {
                            if (user.Name == tempName)
                            {
                                Console.WriteLine("Введите пароль");
                                string tempPassword = Console.ReadLine();
                                if (user.Password == tempPassword)
                                {
                                    MainContr.Loginned = true;
                                }
                            }
                        }
                        break;
                    case 2:
                        User newUser = new User();
                        newUser.CreationDate = DateTime.Now;
                        Console.WriteLine("Введите имя нового пользователя");
                        newUser.Name = Console.ReadLine();
                        Console.WriteLine("Придумайте пароль");
                        newUser.Password = Console.ReadLine();

                        MainContr.UserList.Add(newUser);

                        break;
                }
            }

            if (MainContr.Loginned)
            {
                
            }
        }

        
    }
}
