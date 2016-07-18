using System;

namespace GeneratePrimes
{
  class Program
  {
    static void Main(string[] args)
    {
      SieveOfEratosthenes prime = new SieveOfEratosthenes();
      prime.GeneratePrimes(60);
      Console.ReadLine();      
    }
  }
}
