using HPFizzBuzzer;

namespace HPFBTests
{
    public class Tests
    {
        FizzBuzzer fb;

        [SetUp]
        public void Setup()
        {
            fb = new FizzBuzzer();
        }

        [Test]
        public void TestFizz()
        {
            Assert.True(fb.DetermineFizzBuzz(3) == "Fizz");
        }

        [Test]
        public void TestBuzz()
        {
            Assert.True(fb.DetermineFizzBuzz(5) == "Buzz");
        }

        [Test]
        public void TestFizzBuzz()
        {
            Assert.True(fb.DetermineFizzBuzz(15) == "FizzBuzz");
        }

        [Test]
        public void TestAll()
        {
            Enumerable.Range(1, 100).ToList().ForEach(c =>
            {
                if (c % 15 == 0)
                {
                    Assert.True(fb.DetermineFizzBuzz(c) == "FizzBuzz");
                }
                else if (c % 5 == 0)
                {
                    Assert.True(fb.DetermineFizzBuzz(c) == "Buzz");
                }
                else if (c % 3 == 0)
                {
                    Assert.True(fb.DetermineFizzBuzz(c) == "Fizz");
                }               
                else
                {
                    Assert.True(fb.DetermineFizzBuzz(c) == c.ToString());
                }
            });
        }
    }
}