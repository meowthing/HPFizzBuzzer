namespace HPFizzBuzzer
{
    /**
     * This is quite contrived for FizzBuzz but have separated 
     * the checks as single purpose classes. The idea being
     * you can interchange Fizz or Buzz to get
     * a different calculation with the same input.
     */    
    public class Fizz : IFizzBuzzer
    {
        public static string Check(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            else
                return "";
        }
    }

    public class Buzz : IFizzBuzzer
    {
        public static string Check(int number)
        {
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
                return "";
        }
    }
}
