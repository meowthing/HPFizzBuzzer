using System.Text;

namespace HPFizzBuzzer
{
    public class FizzBuzzer
    {
        public List<IFizzBuzzer> fizzBuzzers = new List<IFizzBuzzer>();

        public FizzBuzzer(List<IFizzBuzzer> fbs)
        {
            fizzBuzzers = fbs;
        }
        
        public string DetermineFizzBuzz(int number)
        {
            StringBuilder resultString = new StringBuilder();

            fizzBuzzers.ForEach(fb => resultString.Append(fb.Check(number)));

            if (string.IsNullOrEmpty(resultString.ToString()))
            {
                return number.ToString();
            }
            return resultString.ToString();
        }
    }
}
