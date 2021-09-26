using System;
using System.Threading;

namespace GuseinGasanov
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer, question;
            Console.WriteLine("Хотите ответить на вопрос?");
            answer = repeatDesicion(Console.ReadLine());
            if (answer == "да" || answer == "Да")
            { 
                Console.WriteLine("Ок, ща\n");
                Thread.Sleep(2000);
                Console.Write("z");
                Thread.Sleep(500);
                Console.Write("z");
                Thread.Sleep(500);
                Console.Write("z");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".\n");
                Thread.Sleep(2000);

                Console.WriteLine("Кто такой Гусейн Гасанов?");
                question = GuseinAnswer(Console.ReadLine());
                if (question == "Гитлер" || question == "Первый Гитлер в России")
                {
                    Console.WriteLine("\nдум через 3...");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n2...");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n1...");
                    Thread.Sleep(1000);
                    System.Environment.Exit(1);
                }
            }
            if (answer == "нет" || answer == "Нет")
            {
                Console.WriteLine("Хотите задать вопрос?");
                answer = repeatDesicion(Console.ReadLine());
                if (answer == "да" || answer == "Да")
                {
                    Console.WriteLine("Какой?");
                    question = GuseinQuestion(Console.ReadLine());
                    Thread.Sleep(1500);
                    Console.Write("Как бы тебе сказать");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(1500);
                    Console.WriteLine("\nЕсли не сидишь, то лучше присядь");
                    Thread.Sleep(3000);
                    Console.WriteLine("Гусейн Гасанов - Гитлер\n");
                    Thread.Sleep(1500);
                    Console.WriteLine("\nдум через 3...");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n2...");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n1...");
                    Thread.Sleep(1000);
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Ну а хули ты тут забыл тогда?");
                    Thread.Sleep(2000);
                    Console.WriteLine("Я пошёл спать");
                    Thread.Sleep(2000);
                    System.Environment.Exit(1);
                }    
            }
        }

        static string repeatDesicion(string desicion)
        {
            do
            {
                if (desicion != "Да" && desicion != "Нет" && desicion != "да" && desicion != "нет")
                {
                    Console.WriteLine("Каво? Повтори");
                    desicion = Console.ReadLine();
                }
            } while (desicion != "Да" && desicion != "Нет" && desicion != "да" && desicion != "нет");
            return desicion;
        }

        static string GuseinAnswer (string answer)
        {
            do
            {
                if (answer != "Гитлер" && answer != "Первый Гитлер в России")
                {
                    Console.WriteLine("ебло нормально отвечай");
                    answer = Console.ReadLine();
                }
            } while (answer != "Гитлер" && answer != "Первый Гитлер в России");
            return answer;
        }
        static string GuseinQuestion(string question)
        {
            do
            {
                if (question != "Кто такой Гусейн Гасанов?")
                {
                    Console.WriteLine("Хуёвый вопрос, не хочу отвечать. По новой давай~");
                    question = Console.ReadLine();
                }
            } while (question != "Кто такой Гусейн Гасанов?");
            return question;
        }
    }
}
