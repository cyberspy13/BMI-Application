using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseByCharles
{
    class BmiCalculation
    {
        public void BmiCalc()
        {
            Console.WriteLine("Enter your height(the number have to be in metres(0.00):");
            decimal heightInput = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter your weight in kilograms:");
            int weightInput = Convert.ToInt32(Console.ReadLine());
            decimal convertVar = 0.010000M;
            decimal getHeightInCm = heightInput / convertVar;

            decimal getResult = (weightInput / (getHeightInCm * 2)) * 100;

            while (true)
            {
                if (getResult < (decimal)18.5)
                {
                    Console.WriteLine($"Your BMI({getResult}) lower then 18.5.You are in UNDERWEIGHT");
                }
                else if (getResult == (decimal)18.5)
                {
                    Console.WriteLine($"Your BMI({getResult}) looks NORMAL");
                }
                else
                {
                    Console.WriteLine($"I am afraid your BMI({getResult})  is OVERWEIGHT");
                }
                Console.ReadLine();
            }

        }
    }
}
