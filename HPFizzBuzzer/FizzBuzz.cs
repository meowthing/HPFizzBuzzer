namespace HPFizzBuzzer
{ 
    public class Fizz : IFizzBuzzer
    {
        public string Check(int number)
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
        public string Check(int number)
        {
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
                return "";
        }
    }

    public class Fazz : IFizzBuzzer
    {
        public string Check(int number)
        {
            if (number % 7 == 0)
            {
                return "Fazz";
            }
            else
                return "";
        }
    }
}
