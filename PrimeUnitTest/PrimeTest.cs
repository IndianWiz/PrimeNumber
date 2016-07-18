using NUnit.Framework;
using GeneratePrimes;

namespace PrimeUnitTest
{
  [TestFixture]
  public class PrimeTest
  {
    [Test]
    [TestCase(2, ExpectedResult = true)]
    [TestCase(3, ExpectedResult = true)]
    [TestCase(4, ExpectedResult = false)]
    [TestCase(16, ExpectedResult = false)]
    [TestCase(17, ExpectedResult = true)]
    public bool IsPrimeTest(int number)
    {
      var calculator = new Prime();
      return calculator.IsPrime(number);
    }

    [Test]
    [TestCase(2)]
    [TestCase(15)]
    [TestCase(30)]
    [TestCase(45)]
    [TestCase(60)]
    public void GeneratePrimeTest(uint time)
    {
      var calculator = new Prime();
      calculator.GeneratePrime(time);
    }

    [Test]
    [TestCase(2)]
    [TestCase(15)]
    [TestCase(30)]
    [TestCase(45)]
    [TestCase(60)]
    public void GenerateSOETest(uint time)
    {
      var calculator = new SieveOfEratosthenes();
      calculator.GeneratePrimes(time);
    }
  }
}
