using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userText;
            int countTextOutput;
            string exitCommand = "exit";
            string exitText;
            bool isExit = false;

            while (isExit == false)
            {
                Console.Write("Введите текст для вывода: ");
                userText = Console.ReadLine();

                Console.Write("Введите сколько раз нужно вывести текст: ");
                countTextOutput = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < countTextOutput; i++)
                    Console.WriteLine((i + 1) + ". " + userText);

                Console.WriteLine("Для выхода напишите exit");
                exitText = Console.ReadLine();
                if (exitText.Equals(exitCommand))
                    isExit = true;
            }

            Console.WriteLine("Выход...");
        }
    }
}