namespace HPFizzBuzzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzer fb = new FizzBuzzer();
            Enumerable.Range(1, 100).ToList().ForEach(c => Console.WriteLine(fb.DetermineFizzBuzz(c)));

        }
    }
}
