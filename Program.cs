using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string SPH, Result = "";
            int Num = 0, i = 1, IPH;
            float Returned = 2;
            Console.WriteLine("Input denary number to convert to hexadecimal:");
            SPH = Console.ReadLine();
            try
            {
                Num = Convert.ToInt32(SPH);
            }
            catch
            {
                Console.WriteLine("Error: Invalid input");
            }
            Returned = Num / 16;
            try
            {
                SPH = Convert.ToString(IPH);
            }
            while (Returned => 1);
            {
                Result = SPH + Result;
                IPH = Math.Pow(16,i)
            }
        }
    }
}
