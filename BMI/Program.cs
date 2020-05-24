using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseByCharles
{
    class Program
    {


        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(100, 1000000);
            List<int> inputListNumbers = new List<int>();
            var count = 0;
            for (int i = 0; i < inputListNumbers.Count(); i++)
            {
                Console.WriteLine(inputListNumbers[i]);
                count++;
            }
            while (true)
            {
                //Console.Clear();
                Console.WriteLine("Enter 6 digits number please:");
                try
                {
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    inputListNumbers.Add(inputNumber);
                    Console.Clear();
                    if (secretNumber == inputNumber && secretNumber.ToString().Length == inputNumber.ToString().Length)
                    {
                        Console.WriteLine("Thats fantastic.You are match the secret number.You are the Champion");
                    }
                    else if (secretNumber < inputNumber && secretNumber.ToString().Length == inputNumber.ToString().Length)
                    {
                        Console.WriteLine($"The 6 digits number you have entered {inputNumber} are too big.\n We are  Sorry.\nDo you want to try again?");
                    }
                    else if (secretNumber > inputNumber && secretNumber.ToString().Length == inputNumber.ToString().Length)
                    {
                        Console.WriteLine($"The 6 digits number you have entered are too small.\n We are  Sorry.\nDo you want to try again?");
                    }
                    else
                    {
                        Console.WriteLine($"You have entered a wrong number.\nCan you try again please");
                    }

                }
                catch
                {
                    Console.WriteLine("Incorrect input!PLease enter the number!");
                    Console.ReadLine();
                }
                  NoMain();

            }

        }
        public static void NoMain()
        { 
            BmiCalculation bmiCalculation = new BmiCalculation();
            bmiCalculation.BmiCalc();

            FrequencyOfWord wordsSearch = new FrequencyOfWord();
            wordsSearch.SearchTheWord();











        }





    }      
    
}
