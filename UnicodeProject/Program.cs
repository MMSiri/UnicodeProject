using System;
using System.IO;
using System.Text;

namespace UnicodeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("eureka.txt", "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes)
            {
                Console.Write("{0} ", b);
            }
            Console.WriteLine(Encoding.UTF8.GetString(eurekaBytes));
        }
    }
}
