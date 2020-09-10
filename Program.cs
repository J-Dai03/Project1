using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string SPH, Result = "";
            int Num = 0, i = 1, IPH = 0;
            float Returned = 2;
            double DPH;

            Console.WriteLine(Convert.ToString(DecToHexChar('1')))

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


            try
            {
                SPH = Convert.ToString(IPH);
            }
            catch
            {
                Console.WriteLine("Unknown Error");
            }



            do
            {
                Result = SPH + Result;
                DPH = Math.Pow((Convert.ToDouble(16)), Convert.ToDouble(i));
            } while (Returned >= 1.0);
        }

        static char DecToHexChar(char x)
        {
            char HexChar = '1';
            char[] characters;
            characters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
            HexChar = characters[x-1];
            return HexChar;

        }

    }
}
