using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseByCharles
{
    class FrequencyOfWord
    {
        public void SearchTheWord()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>(); // so dictionary should be outside the scope
            bool correct = false;
            while (!correct)
            {
                Console.WriteLine("Enter the sentences what you want me to check:");
                string stringInput = Console.ReadLine().ToLower();
                string[] stringSplit = stringInput.Split(' ');
                foreach (string words in stringSplit)
                {
                    if (dict.ContainsKey(words))  // checking if my words existing or not
                    {
                        int value = dict[words];
                        dict[words] = value + 1;
                    }
                    else
                    {
                        dict[words] = 1;
                    }
                }
                foreach (KeyValuePair<string, int> occuranceDict in dict) 
                {
                    Console.WriteLine(occuranceDict.Key + " Counts are: " + occuranceDict.Value);
                    Console.ReadKey();
                }
            }
        }
    }
}
