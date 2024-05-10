using HPFizzBuzzer;

namespace HPFBTests
{
    public class Tests
    {
        FizzBuzzer fb;

        [SetUp]
        public void Setup()
        {
            List<IFizzBuzzer> fizzBuzzers = new List<IFizzBuzzer>
            {
                new Fizz(), new Buzz()
            };
            fb = new FizzBuzzer(fizzBuzzers);
        }

        [Test]
        public void TestFizz()
        {
            Assert.That(fb.DetermineFizzBuzz(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void TestBuzz()
        {
            Assert.That(fb.DetermineFizzBuzz(5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void TestFizzBuzz()
        {
            Assert.That(fb.DetermineFizzBuzz(15), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void TestNumber()
        {
            Assert.That(fb.DetermineFizzBuzz(2), Is.EqualTo("2"));
        }
    }
}