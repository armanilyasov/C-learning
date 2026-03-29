using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CScouse1
{
    internal class autorizarionTest
    {
        static void Main(string[] args)
        {  
            string login = "arman";
            string password = "arman123";
            int colvoCount = 5;

            for (int i = 0; i < colvoCount; i++)
            {
                Console.Write("Введите логин: ");
                string typingLogin = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string typingPassword = Console.ReadLine();

                if (login == typingLogin)
                {
                    if (password == typingPassword)
                    {
                        Console.WriteLine("Вы вошли в аккаунт!");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Неверный пароль!");
                        Console.WriteLine($"Осталось {colvoCount - (i + 1)} попыток.");
                    }
                }
                else
                {
                    Console.WriteLine("Такого аккаунта не существует!");
                    Console.WriteLine($"Осталось {colvoCount - (i + 1)} попыток.");
                }
            
            }  
        }
    }
}
