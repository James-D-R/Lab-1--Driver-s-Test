using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Minnesota driver's liscense test grading program.");
            string[] correctAnswers = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
            string exit = "Y";
            while (exit == "Y")
            {
                string[] userAnswers = { };
                Console.WriteLine("\nFor each question enter the student's answer A, B, C, or D.\nPress enter to begin.");
                Console.ReadLine();

                for (int x = 1; x <= correctAnswers.Length; x++)
                {
                    Console.WriteLine("Question #{0}", x);
                    string userResponse = Console.ReadLine();
                    string a = userResponse.ToUpper();
                    while (a != "A" && a != "B" && a != "C" && a != "D")
                    {
                        Console.WriteLine("Invalid option. Please enter a letter A - D.");
                        userResponse = Console.ReadLine();
                        a = userResponse.ToUpper();
                    }

                    string[] b = { a };
                    userAnswers = userAnswers.Concat(b).ToArray();
                }
                Console.Clear();

                string[] correctHolder = { };
                string[] correct = { "correct" };
                string[] incorrect = { "incorrect" };
                int numberCorrect = 0;
                for (int x = 0; x < userAnswers.Length; x++)
                {
                    if (userAnswers[x] == correctAnswers[x])
                    {
                        correctHolder = correctHolder.Concat(correct).ToArray();
                        numberCorrect = numberCorrect + 1;
                    }
                    else
                    {
                        correctHolder = correctHolder.Concat(incorrect).ToArray();
                    }

                }
                if (numberCorrect >= 15)
                {
                    Console.WriteLine("\nPass. Student scored {0} out of 20", numberCorrect);
                    Console.WriteLine("{0} questions answered correctly.", numberCorrect);
                    Console.WriteLine("{0} questions answered incorrectly.", 20 - numberCorrect);
                }
                else
                {
                    Console.WriteLine("\nFailed. Student scored {0} out of 20", numberCorrect);
                    Console.WriteLine("{0} questions answered correctly.", numberCorrect);
                    Console.WriteLine("{0} questions answered incorrectly.\n", 20 - numberCorrect);
                }
                for (int x = 0; x < correctHolder.Length; x++)
                {
                    if (correctHolder[x] == "incorrect")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Question #{0}: {1}", x + 1, correctHolder[x]);
                    }
                    if (correctHolder[x] == "correct")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Question #{0}: {1}", x + 1, correctHolder[x]);
                    }
                   

                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nWould you like to grade another exam (Y/N)?");
                string n = Console.ReadLine();
                exit = n.ToUpper();

            }
            Console.WriteLine("Press enter to exit.");

            Console.ReadLine();
        }
    }
}
