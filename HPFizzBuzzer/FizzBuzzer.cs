using System.Text;

namespace HPFizzBuzzer
{
    public class FizzBuzzer
    {
        public string DetermineFizzBuzz(int number)
        {
            StringBuilder resultString = new StringBuilder();

            resultString.Append(Fizz.Check(number));
            resultString.Append(Buzz.Check(number));

            if (string.IsNullOrEmpty(resultString.ToString()))
            {
                return number.ToString();
            }
            return resultString.ToString();
        }
    }
}
