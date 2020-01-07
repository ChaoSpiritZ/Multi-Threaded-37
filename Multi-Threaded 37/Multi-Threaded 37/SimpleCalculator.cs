using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threaded_37
{
    class SimpleCalculator
    {
        public int NumberGetter()
        {
            int num = -1;
            do
            {
                Console.WriteLine("Please input a positive number: ");
            }
            while (int.TryParse(Console.ReadLine(), out num) == false || num <= 0);
            return num;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Please input 1-4 to select an operation: ");
            Console.WriteLine("1 => +");
            Console.WriteLine("2 => -");
            Console.WriteLine("3 => x");
            Console.WriteLine("4 => /");
        }

        public int GetUserChoice()
        {
            int choice = -1;
            //while(int.TryParse(Console.ReadLine(), out choice) == false || (choice != 1 && choice != 2 && choice != 3 && choice != 4))
            //{
            //}
            while (true)
            {
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1: return choice;
                    case 2: return choice;
                    case 3: return choice;
                    case 4: return choice;
                    default:
                        break;
                }
            }
        }

        public double Calculate(int operand1, int operand2, int operation)
        {
            if(operation == 1)
            {
                return operand1 + operand2;
            }
            if (operation == 2)
            {
                return operand1 - operand2;
            }
            if (operation == 3)
            {
                return operand1 * operand2;
            }
            if (operation == 4)
            {
                return operand1 / operand2;
            }
            else
            {
                throw new ArgumentException($"the operation choice you have entered is invalid! [{operation}], must be a whole number between 1-4!");
            }
        }

        public void PrintResultNicely(double result)
        {
            Console.WriteLine($">---[{result}]---<");
        }
    }
}
