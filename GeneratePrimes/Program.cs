using System;

namespace GeneratePrimes
{
  class Program
  {
    static void Main(string[] args)
    {
      Prime prime = new Prime();
      prime.GeneratePrime(60);
      Console.ReadLine();
    }
  }
}
