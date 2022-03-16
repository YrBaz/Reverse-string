namespace ReverseString
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Input string: ");
            var input = Console.ReadLine();

            if (input == null)
            {
                return;
            }

            var result = ReverseString.Reverse(input);

            Console.WriteLine("Reversed string: " + result);
        }
    }
}