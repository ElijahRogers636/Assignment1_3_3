namespace Assignment1_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Write a program in C# to read n number of values in an array and display it in reverse order.

            Console.WriteLine("Choose the size of the array you want to create");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] vals = new int[n];

            // Initializes a new random object
            Random rand = new Random();

            Console.WriteLine();

            // Adds random integers between 0-50 to vals array and prints each element out to the console
            for (int i = 0; i < n; i++)
            {
                vals[i] = rand.Next(50);
                Console.Write(vals[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Prints the array in descending order starting at n - 1. Makes it easier to compare array manipulation correctness.
            for (int i = 0; i < n; i++)
            {
                Console.Write(vals[(n - 1) - i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Actually Reverses the array
            for (int i = 0; i < n / 2; i++)
            {
                int temp = vals[i];
                vals[i] = vals[(n - 1) - i];
                vals[(n - 1) - i] = temp;
            }

            // Prints out the array in ascending order
            foreach (int elem in vals)
            {
                Console.Write(elem + " ");
            }
        }
    }
}
