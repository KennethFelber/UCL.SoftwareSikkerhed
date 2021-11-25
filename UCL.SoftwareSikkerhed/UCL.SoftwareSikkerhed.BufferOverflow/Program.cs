using System;

namespace UCL.SoftwareSikkerhed.BufferOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string[16];
            var tmp = "Hep hest";
            Console.WriteLine(tmp);
            try
            {
                for (int i = 1; i <= 17; i++)
                {
                    array[i] = "hep hey";
                }
                Console.WriteLine(tmp);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
