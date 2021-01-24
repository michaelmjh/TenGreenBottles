using System;

namespace TenGreenBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainingBottles = 10;
            string pluralS = "s";

            while (remainingBottles > 0)
            {
                Console.WriteLine($"{remainingBottles} green bottle{pluralS} standing on the wall");
                remainingBottles--;
                if (remainingBottles == 1)
                {
                    pluralS = "";
                }
            }
            
        }
    }
}
