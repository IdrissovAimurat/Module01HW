using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            simpleConsoleApp();

            //exercise1();

            //exercise2();

        }

        /// <summary>
        /// Создать простое консольное приложение и ознакомиться с его структурой
        /// </summary>
        static void simpleConsoleApp()
        {
            Console.WriteLine("Сәлем әлем!\n" + "\nПриветствую Вас на своем 1 практическом задании!\n");
        }

        /// <summary>
        /// Написать приложение, которое выведет на экран Ваше имя и фамилию. 
        /// (Жду что у вас будет приложение, которое я сам запущу и 
        /// где у меня попросят ввести ФИО, после я нажму Enter и 
        /// мне выдастся сообщение – «Приветствую тебя - ФИО»)
        /// </summary>

        static void exercise1()
        {
            Console.WriteLine("Извиняюсь, хотел бы УТОЧНИТЬ ваше ФИО: \n");


            Console.Write("Ваше фамилия - ");
            string surnameName = Console.ReadLine();


            Console.Write("Ваше имя - ");
            string name = Console.ReadLine();


            Console.Write("Ваше отчество - ");
            string patronomyc = Console.ReadLine();
            

            Console.WriteLine("\nПриветствую тебя - " + name + " " + surnameName + " " + patronomyc + "\n");
        }

        /// <summary>
        /// Написать приложение, которое ожидает ввода нескольких чисел и
        /// выводит на экран их сумму. 
        /// (Так же как и в предыдущем примере, только с цифрами. 
        /// Мы проходили как можно из строки перевести в число.)
        /// </summary>
        
        static void exercise2()
        {
            int sum = 0;
            bool input = true;

            while (input)
            {
                Console.Write("Для ввода чисел введите число или для выхода нажмите 'выйти': \n");
                
                string subject = Console.ReadLine();

                if (subject.ToLower() == "выйти")
                {
                    input = false;
                }
                else
                {
                    if (int.TryParse(subject, out int number))
                    {
                        //Буду честен, время 3:14, и логику с суммированием чисел чет затупил и решил у чата(((
                        sum += number;
                        Console.WriteLine("сумма = " + sum + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\nВы ввели не число. Пожалуйства введите число или напишите 'выйти', если хотите завершить данное действие\n");
                    }
                }
            }
            Console.WriteLine("\nИтоговое число = " + sum + "\n");
        }
    }
}
