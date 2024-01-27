namespace GuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secret = 55;
            int answer = 0;
            int tries = 10;

            while (answer != secret && tries > 0)
            { 
                Console.Write("Guess the number: ");
                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect number input!");
                    continue;
                }

                tries--;

                if (answer < secret)
                {
                    Console.WriteLine("No, it is higher! Try again! " + tries + " " + (tries > 1 ? "tries" : "try") + " left.");
                }
                else if (answer > secret)
                {
                    Console.WriteLine("No, it is lower! Try again! " + tries + " " + (tries > 1 ? "tries" : "try") + " left.");
                }
            }

            if (tries > 0)
            {
                Console.WriteLine("Yes, you are right! The number is " + secret + '!');
            }
            else
            {
                Console.WriteLine("Oh no, you are out of tries!");
            }
        }
    }
}
