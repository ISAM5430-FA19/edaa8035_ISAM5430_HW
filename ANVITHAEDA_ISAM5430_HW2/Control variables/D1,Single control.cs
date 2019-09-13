using System;

namespace Control_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int num=0;
            //int count = int.Parse(Console.ReadLine());
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int cur = num;
            int firstHalfSum = 0;
            int secondHalfSum = 0;
            int mid = count / 2;
                       
            Console.WriteLine("enter the count of numbers you want to enter:");
            int count = int.Parse(Console.ReadLine());
            int mid = count % 2;

            Console.Write("enter the numbers:");
            for (int i = 0; i <= count; i++)
            {
                num = int.Parse(Console.ReadLine());
               if(i<mid)
                {
                    firstHalfSum += num;
                }
               else if (count % 2 == 0 && i >= mid)
                {
                    secondHalfSum += num;
                }

               
                // counting positive integers
                if (num > 0)
                {
                    total++;
                    Console.WriteLine("positive numbers" + count);

                }

                //counting number of 0's
                if (num == 0)
                {
                    total++;
                    Console.WriteLine("zeros:" + count);
                }

                //counting even numbers
                if(num%2==0)
                {
                    total++;
                    Console.WriteLine("even numbers:" + count);
                }

                //largest number
                if (num > max)
                {
                    max = num;
                    Console.WriteLine("maximum" + max);

                }

                //smallest number
                if (num < min)
                {
                    min = num;
                    Console.WriteLine("minimum" + min);

                }
                
               //
                if (cur > num)
                {
                    flag = true;
                }





            }
        }
    }
}
