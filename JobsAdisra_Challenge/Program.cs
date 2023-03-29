/*using JobsAdisra_Challenge.Exercises;*/
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("MyBoy ");
        int n = Convert.ToInt16(Console.ReadLine());

        if (n <= 1)
        {
            Console.WriteLine("O valor de n é: " + n);
        }
        else
        {
            int[] fibonacciSequence = new int[n + 1];
            fibonacciSequence[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
            }

            Console.WriteLine("O valor do qual n é: " + n);
        }
    }
}