using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CheckIsEvenNumber
    {

        public string OutputCheckMessage(int num)
        {
            bool isEven = IsEven(num);
            return isEven ? $"Число - {num} четное  " : $"Число - {num} нечетное  ";
        }

        public bool IsEven(int num) {

            return num % 2 == 0;
        }

        public void IsEvenNumber()
        {
            Console.WriteLine("Введите число для проверки:");
            string? userInput = Console.ReadLine();
            if (userInput != null)
            {
                int userInputNumber = Convert.ToInt32(userInput);
                string result = OutputCheckMessage(userInputNumber);
                Console.WriteLine(result);  
            }
            
        }
    }
}
