using System.Reflection.Metadata.Ecma335;

namespace _1._3Uzduotis_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = CreateRandomPassword();
            Console.WriteLine(password);
        }


        public static char ReturnRandomLetter()
        {

            Random random = new Random();

            int letterNumber = random.Next(65, 91);

            char letter = Convert.ToChar(letterNumber);

            return letter;
        }


        public static string CreateRandomPassword()
        {
            Random random = new Random();
            List<char> password = new List<char>();

            for (int i = 0; i < 10; i++)
            {
                char letter = ReturnRandomLetter();
                password.Add(letter);
            }
            return new string(password.ToArray());


        }
    }

}
