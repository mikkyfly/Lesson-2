//Задание 1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
//Задание 2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.
//Задание 3. Определить, является ли введённое пользователем число чётным.
//Задание 4. Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1
            Console.WriteLine("Задание 1");
            MinMaxTemp();
            #endregion

            #region Задание 2 и Задание 4 вместе.
            Console.WriteLine("Задание 2 и Задание 4");
            Console.WriteLine("Введите число месяца");
            int monthNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите его температуру");
            int temp = Convert.ToInt32(Console.ReadLine());
            Month(monthNumb,temp);
            #endregion

            #region Задание 3
            Console.WriteLine("Задание 3");
            ParityNumber();
            #endregion

            

        }

        static void MinMaxTemp()
        {
            Console.WriteLine("Введите минимальную  температуру за сутки");
            int minTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            int maxTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Минимальная температура которую вы ввели: " + minTemp);
            Console.WriteLine("Максимальная температура которую вы ввели: " + maxTemp);
        }

        static void Month(int monthNumb, int temperatur )
        {
            

             
            switch (monthNumb)
            {
                case 1:
                    Console.WriteLine("Январь");
                    if (temperatur>0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    if (temperatur > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    if (temperatur > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                default:
                    Console.WriteLine("Вы ввели ошибочную цифру");
                    break;
            }

        }

        static void ParityNumber()
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number%2)==0)
            {
                Console.WriteLine("Число четное");
                
            }
            else
            {
                Console.WriteLine("Число не четное");
            }
        }


    }
}
