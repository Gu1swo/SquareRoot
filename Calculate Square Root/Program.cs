using System;

namespace Calculate_Square_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, root = 1, i = 1;

            Console.WriteLine("enter a number to calculate sqrt");
            input = Convert.ToInt32(Console.ReadLine());

            while (i <= input) {
                if (root * i == input) {
                    Console.WriteLine("the sqrt of the number: " + input + " is: " + root);
                    break;
                }  
                root++;
                i++;
            }

            if(root * root != input)
                Console.WriteLine(input + " is not a square root");
        }
    }
}
