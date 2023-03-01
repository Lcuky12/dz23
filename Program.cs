using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string stopWord = "exit";
            bool canExamination = true;

            while (canExamination) 
            {
                Console.WriteLine("Введите сообщение");
                userInput= Console.ReadLine();

                if (userInput == stopWord)
                {
                   canExamination= false;
                }
            }
        }
    }
}
