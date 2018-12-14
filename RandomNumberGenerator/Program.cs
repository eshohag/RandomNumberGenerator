using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var verificationCode = GenerateVerificationCode(1000, 9999);
            Console.WriteLine(verificationCode);
            Console.ReadKey();
        }
        private static int GenerateVerificationCode(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
