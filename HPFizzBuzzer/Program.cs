namespace HPFizzBuzzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFizzBuzzer> fizzBuzzers = new List<IFizzBuzzer>
            {
                new Fizz(), new Buzz(), new Fazz()
            };
            FizzBuzzer fb = new FizzBuzzer(fizzBuzzers);
            Enumerable.Range(1, 100).ToList().ForEach(c => Console.WriteLine(fb.DetermineFizzBuzz(c)));

        }
    }
}
