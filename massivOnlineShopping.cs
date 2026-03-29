using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CScouse1
{
    internal class massivOnlineShopping
    {
        static void Main(string[] args)
        {
            int[] countPozition = { 15, 23, 12 };
            string[] namePozition = { "Трико", "Футболка", "Куртка" };

            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);

                for (int i = 0; i < countPozition.Length; i++)
                {
                    Console.WriteLine($"В позиции {namePozition[i]}, осталось {countPozition[i]} шт.");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"Регистрация заказа.");
                Console.WriteLine($"\n1 - Все товары.\n2 - Выйти из программы.");
                Console.Write($"\n\nВыберите значение: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        String userNamePozition;
                        int userCountPozition;
                        Console.Write("\nКакой товар вы хотите продать?\n");
                        userNamePozition = Console.ReadLine();
                        // Трико
                        if (userNamePozition == namePozition[0])
                        {
                            Console.Write($"Введите количество товара: ");
                            userCountPozition = Convert.ToInt32(Console.ReadLine());
                            if (userCountPozition > 0 && userCountPozition <= countPozition[0])
                            {
                                countPozition[0] -= userCountPozition;
                                Console.WriteLine($"Вы продали {userCountPozition} шт." +
                                    $"\nНа складе осталось {countPozition[0]}");
                            }
                            else
                            {
                                Console.WriteLine($"Недостаточно товаров на складе. На складе " +
                                    $"{countPozition[0]}");
                            }

                        }

                        // Футболка
                        else if (userNamePozition == namePozition[1])
                        {
                            Console.Write($"Введите количество товара: ");
                            userCountPozition = Convert.ToInt32(Console.ReadLine());
                            if (userCountPozition > 0 && userCountPozition <= countPozition[1])
                            {
                                countPozition[1] -= userCountPozition;
                                Console.WriteLine($"Вы продали {userCountPozition} шт." +
                                    $"\nНа складе осталось {countPozition[1]}");
                            }
                            else
                            {
                                Console.WriteLine($"Недостаточно товаров на складе. На складе " +
                                    $"{countPozition[1]}");
                            }
                        }

                        // Куртка
                        else if (userNamePozition == namePozition[2])
                        {
                            Console.Write($"Введите количество товара: ");
                            userCountPozition = Convert.ToInt32(Console.ReadLine());
                            if (userCountPozition > 0 && userCountPozition <= countPozition[2])
                            {
                                countPozition[2] -= userCountPozition;
                                Console.WriteLine($"Вы продали {userCountPozition} шт." +
                                    $"\nНа складе осталось {countPozition[2]}");
                            }
                            else
                            {
                                Console.WriteLine($"Недостаточно товаров на складе. На складе " +
                                    $"{countPozition[2]}");
                            }
                        }
                        break;
                    case 2:
                        isOpen = false;
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
