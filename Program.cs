namespace BoxingAndUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            object obj = 10;
            DisplayObj("");

        }

        static void DisplayObj(object obj)
        {
            string message = (string)obj;
            Console.WriteLine(message);
        }

    }
}
