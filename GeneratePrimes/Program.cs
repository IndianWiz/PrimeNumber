using System;

namespace GeneratePrimes
{
  class Program
  {
    static void Main(string[] args)
    {
      Prime prime = new Prime(60);
      prime.GeneratePrime();
      Console.ReadLine();
    }
  }
}
