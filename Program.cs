using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        public static void Calculator()
        {
            float number1;
            float number2;

            string operation;
            
            float answer;

            Console.WriteLine("Please enter a number");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which of the following would you like to do: + , - , * , / ");
            operation = Console.ReadLine();

            Console.WriteLine("Second number please ;)");
            number2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    answer = number1 + number2;
                    break;
                case "-":
                    answer = number1 - number2;
                    break;
                case "*":
                    answer = number1 * number2;
                    break;
                case "/":
                    answer = (number1/number2);
                    break;
                default:
                    answer = 0f;
                    break;
            }
            Console.Clear();
            Success(answer);
        }
        // extra
        private static void Success(float answer)
        {

            string exit;

            Console.WriteLine(" ");
            Console.WriteLine("──────────────███████──███████");
            Console.WriteLine("──────────████▓▓▓▓▓▓████░░░░░██");
            Console.WriteLine("────────██▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░░██");
            Console.WriteLine("──────██▓▓▓▓▓▓████████████░░░░██");
            Console.WriteLine("────██▓▓▓▓▓▓████████████████░██");
            Console.WriteLine("────██▓▓████░░░░░░░░░░░░██████");
            Console.WriteLine("──████████░░░░░░██░░██░░██▓▓▓▓██");
            Console.WriteLine("──██░░████░░░░░░██░░██░░██▓▓▓▓██");
            Console.WriteLine("██░░░░██████░░░░░░░░░░░░░░██▓▓██");
            Console.WriteLine("██░░░░░░██░░░░██░░░░░░░░░░██▓▓██");
            Console.WriteLine("──██░░░░░░░░░███████░░░░██████          Your Answer is " + answer.ToString());
            Console.WriteLine("────████░░░░░░░███████████▓▓██");
            Console.WriteLine("──────██████░░░░░░░░░░██▓▓▓▓██ Would you like to calculate anything else? Yes | No  ");
            Console.WriteLine("────██▓▓▓▓██████████████▓▓██");
            Console.WriteLine("──██▓▓▓▓▓▓▓▓████░░░░░░████");
            Console.WriteLine("████▓▓▓▓▓▓▓▓██░░░░░░░░░░██");
            Console.WriteLine("██████▓▓▓▓▓▓▓▓██░░░░░░████████");
            Console.WriteLine("──██████▓▓▓▓▓▓████████████████");
            Console.WriteLine("────██████████████████████▓▓▓▓██");
            Console.WriteLine("──██▓▓▓▓████████████████▓▓▓▓▓▓██");
            Console.WriteLine("████▓▓██████████████████▓▓▓▓▓▓██");
            Console.WriteLine("██▓▓▓▓██████████████████▓▓▓▓▓▓██");
            Console.WriteLine("██▓▓▓▓██████████──────██▓▓▓▓████");
            Console.WriteLine("██▓▓▓▓████──────────────██████ ");
            Console.WriteLine("──████");
            Console.WriteLine(" ");

            exit = Console.ReadLine();

            switch (exit)
            {
                case "Yes":
                    Console.Clear();
                    Calculator();
                    break;
                default:
                    break;
            }
        }



    }
}
