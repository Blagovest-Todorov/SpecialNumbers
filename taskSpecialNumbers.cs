using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            for (int inumber = 1111; inumber <= 9999; inumber++)
            {
                //string currNum = i.ToString();
                //Console.WriteLine(currNum);
                bool isSpecial = true;

                for (int index = 0; index < 4; index++)
                {
                    int digit = int.Parse(inumber.ToString()[index].ToString());
                    if (digit == 0)
                    {
                        isSpecial = false;
                        break;
                    }

                    if (num % digit != 0)
                    {
                        isSpecial = false;
                    }

                }

                if (isSpecial)
                {
                    Console.Write($"{inumber} ");
                    count++;
                }

            }
            Console.WriteLine();
            Console.WriteLine(count);
        }
    }
}
