// See https://aka.ms/new-console-template for more information

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            if (args.Length > 0)
            {
                Console.WriteLine(args[0]);
            }

        }

    }

}