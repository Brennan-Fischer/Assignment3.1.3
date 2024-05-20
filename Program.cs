namespace Assignment3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Please input phrase to count the number of spaces");
            string readResult = Console.ReadLine();
            Console.WriteLine("Please input phrase to count the number of spaces");
            char charToCount = Convert.ToChar(Console.ReadLine());
            foreach (char c in readResult)
            {
                if(charToCount == c)
                {
                    count++;
                }
            }
            Console.WriteLine("There are " + count + " instances of your character");
        }
    }
}
