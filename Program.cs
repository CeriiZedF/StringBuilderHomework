using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderHomework
{
    internal class Program
    {
        static void Main()
        {
            #region 1

            var str = new StringBuilder(String.Empty);

            Console.WriteLine("Input Text: ");
            str.AppendLine(Console.ReadLine());    
            
            bool f = true;
            int j = str.Length - 3;
            for (int i = 0; i < str.Length / 2;)
            {
                if(str[i] == ' ' || ',' == str[i])
                {
                    i++;
                    Console.WriteLine("ISpace or comma");
                    continue;
                }
                if (str[j] == ' ' || ',' == str[j])
                {
                    j--;
                    Console.WriteLine("JSpace or comma");
                    continue;
                }

                else if (str[i] != str[j])
                {
                    f = false;
                    Console.WriteLine($"ID1: {i} - Value: {str[i]}  =  ID2: {j} - Value: {str[j]}   False");
                    break;
                }
                else
                {
                    Console.WriteLine($"ID1: {i} - Value: {str[i]}  =  ID2: {j} - Value: {str[j]}  True");
                    j--;
                    i++;
                }

            }

            if (f)
            {
                Console.WriteLine("Полиндром");
            }
            else
            {
                Console.WriteLine("Не полиндром");
            }
            #endregion
        }
    }
}
