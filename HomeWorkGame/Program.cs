using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Рандомное число для игры
            Random randValue = new Random();
            

            for (;;)
            {
                Console.WriteLine("Привет не хочешь сыграть в игру?" +
               "\nНажмите: 1 - если да" +
               "\nНажмите: 2 - если нет");
                //Переменная хранит ответ пользователя
                int userResponse = int.Parse(Console.ReadLine());
                //Условие для обработки исключений 
                if (userResponse == 1)
                {
                    Console.Clear();
                    //Цикл выбора игры
                    for (;;)
                    {
                        Console.WriteLine("Отлично!!!\n" +
                        "С кем будете играть?" +
                        "\nНажмите: 1 - с другом" +
                        "\nНажмите: 2 - с компьютером");
                        int userResponseCountPlaers = int.Parse(Console.ReadLine());
                        //проверка на корректность
                        if (userResponseCountPlaers == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите ваши никнеймы");
                            Console.Write("1 - игрок: ");
                            string firstPlaers = Console.ReadLine();
                            Console.Write("2 - игрок: ");
                            string secondPlaers = Console.ReadLine();

                            Console.WriteLine("Введите диапозон числа генерации");
                            Console.WriteLine("От кого числа начать генерацию - ");
                            int valueOt = int.Parse(Console.ReadLine());
                            Console.WriteLine("До кого числа начать генерацию - ");
                            int valueDo = int.Parse(Console.ReadLine());

                            int gameNumberFreand = randValue.Next(valueOt, valueDo);

                            Console.Clear();

                            Console.WriteLine("Игра началась");
                            //Алгоритм игры с другом
                            for (;;)
                            {
                               if (gameNumberFreand >= 0)
                               {
                                    //Проверка 1 игрока
                                    for (;;)
                                    {
                                        Console.WriteLine($"Число: {gameNumberFreand}");
                                        Console.WriteLine($"Игрок: {firstPlaers}");
                                        int stepFirstUsers = int.Parse(Console.ReadLine());
                                        if (stepFirstUsers > 0 && stepFirstUsers <= 4)
                                        {
                                            gameNumberFreand = gameNumberFreand - stepFirstUsers;
                                            if (gameNumberFreand <= 0)
                                            {
                                                Console.WriteLine($"{firstPlaers} - победил!!!");
                                                break;
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Вы ввели не правильное число! от 1 до 4");
                                        }
                                    }
                                    //Проверка 2 игрока
                                    for (;;)
                                    {
                                        Console.WriteLine($"Число: {gameNumberFreand}");
                                        Console.WriteLine($"Игрок: {secondPlaers}");
                                        int stepFirstUsers = int.Parse(Console.ReadLine());
                                        if (stepFirstUsers > 0 && stepFirstUsers <= 4)
                                        {
                                            gameNumberFreand = gameNumberFreand - stepFirstUsers;
                                            if (gameNumberFreand <= 0)
                                            {
                                                Console.WriteLine($"{secondPlaers} - победил!!!");
                                                break;
                                            }
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Вы ввели не правильное число! от 1 до 4");
                                        }
                                    }
                               }
                               else
                               {
                                  break;
                               }
                                
                            }
                             
                        }
                        else if (userResponseCountPlaers == 2)
                        {
                            //Алгоритм игры с ПК
                            Random randSolo = new Random();
                            Console.Clear();
                            Console.Write("Введитe ваш никнейм: ");
                            string nicknamesSolo = Console.ReadLine();

                            Console.WriteLine("Введите диапозон числа генерации");
                            Console.WriteLine("От кого числа начать генерацию - ");
                            int valueOt = int.Parse(Console.ReadLine());
                            Console.WriteLine("До кого числа начать генерацию - ");
                            int valueDo = int.Parse(Console.ReadLine());

                            int gameNumberSolo = randValue.Next(valueOt, valueDo);

                            Console.Clear();

                            Console.WriteLine("Игра началась");


                            //создаём переменную invers типа bool. Далее по коду: если invers==true, ходит первый игрок, если invers==false -- то второй
                            bool invers = true;

                            while(gameNumberSolo > 0)
                            {
                                if (invers)
                                {
                                    Console.WriteLine($"Число: {gameNumberSolo}");
                                    Console.WriteLine($"Игрок: {nicknamesSolo}");

                                    int stepSolo = int.Parse(Console.ReadLine());
                                    while (stepSolo > 0 && stepSolo > 4)
                                    {
                                        Console.WriteLine("Вы ввели не правильное число! от 1 до 4");
                                        stepSolo = int.Parse(Console.ReadLine());
                                    }
                                    gameNumberSolo -= stepSolo;
                                    invers = !invers;
                                }
                                else
                                {
                                    Console.WriteLine($"Число: {gameNumberSolo}");
                                    Console.WriteLine($"Игрок: КОМПЬЮТЕР");
                                    int smartPc = randSolo.Next(1, 5);
                                    gameNumberSolo -= smartPc;
                                    invers = !invers;
                                }

                            }
                            if (!invers)
                            {
                                Console.WriteLine($"{nicknamesSolo} - Победил!");
                            }
                            else
                            {
                                Console.WriteLine($"КОМПЬЮТЕР - Победил!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели не коректное число!!!" +
                               "\nПовторите попытку");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
                else if(userResponse == 2)
                {
                    Console.WriteLine("До свидания!!!" +
                        "\nНажмите кнопку для выхода");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели не коректное число!!!" +
                        "\nПовторите попытку");
                    Console.ReadKey();
                    Console.Clear();
                }
                
            }
        }
    }
}
