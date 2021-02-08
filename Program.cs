using System;

namespace TenGreenBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainingBottles = 5;
            string pluralS = "s";

            while (remainingBottles > 0)
            {
                Console.WriteLine($"{remainingBottles} green bottle{pluralS} standing on the wall");
                Console.WriteLine($"and if 1 green bootle should accidently fall");
                remainingBottles--;
                if (remainingBottles == 1)
                {
                    pluralS = "";
                }
                else
                {
                    pluralS = "s";
                }
                Console.WriteLine($"there will be {remainingBottles} green bottle{pluralS} standing on the wall");
                Console.WriteLine();
            }
        }
    }
}
