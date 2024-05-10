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
                new Fizz(), new Buzz(), new Fazz()
            };
            fb = new FizzBuzzer(fizzBuzzers);
        }

        [Test]
        public void TestFizz()
        {
            Assert.That(fb.DetermineFizzBuzz(3), Does.Contain("Fizz"));
        }

        [Test]
        public void TestBuzz()
        {
            Assert.That(fb.DetermineFizzBuzz(5), Does.Contain("Buzz"));
        }

        [Test]
        public void TestFizzBuzz()
        {
            Assert.That(fb.DetermineFizzBuzz(15), Does.Contain("FizzBuzz"));
        }

        [Test]
        public void TestFazz()
        {
            Assert.That(fb.DetermineFizzBuzz(7), Does.Contain("Fazz"));
        }

        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(5, "Buzz")]
        [TestCase(3, "Fizz")]
        [TestCase(7, "Fazz")]
        [TestCase(70, "BuzzFazz")]
        [TestCase(84, "FizzFazz")]
        public void TestCases(int number, string word)
        {
            Assert.That(fb.DetermineFizzBuzz(number), Does.Contain(word));
        }

        [Test]
        public void TestNumber()
        {
            Assert.That(fb.DetermineFizzBuzz(2), Is.EqualTo("2"));
        }
    }
}