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

            while (true)
            {
                Console.Write("Введите текст для вывода: ");
                userText = Console.ReadLine();

                if(userText.Equals(exitCommand))
                    break;

                Console.Write("Введите сколько раз нужно вывести текст: ");
                countTextOutput = Convert.ToInt32(Console.ReadLine());

                if (countTextOutput.Equals(exitCommand))
                    break;

                for (int i = 0; i < countTextOutput; i++) Console.WriteLine((i + 1) + ". " + userText);
            }

            Console.WriteLine("Выход...");
        }
    }
}