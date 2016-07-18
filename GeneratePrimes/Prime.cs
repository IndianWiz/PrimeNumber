using System;
using System.Diagnostics;

namespace GeneratePrimes
{
  /// <summary>
  /// Basic implementation to get prime numbers.
  /// </summary>
  public class Prime
  {
    readonly Stopwatch _watch = new Stopwatch();  

    /// <summary>
    /// Generates prime numbers for a given duration.
    /// We improve speed by only checking odd numbers for primes.
    /// </summary>
    /// <param name="time">Duration to generate prime numbers.</param>
    public void GeneratePrime(uint time)
    {     
      int number = 3;
      int maxPrime = number;
      _watch.Start();
      while (_watch.Elapsed.TotalSeconds <= time)
      {
        if (IsPrime(number))
        {
          maxPrime = number;
          Console.WriteLine(_watch.Elapsed.Seconds + ":" + maxPrime);
        }
        number += 2;
      }
      _watch.Stop();
      Console.WriteLine("Max Prime " + maxPrime);
    }

    /// <summary>
    /// Checks if a given number is prime.
    /// </summary>
    /// <param name="number">Number to check.</param>
    /// <returns>True, if number is prime else False.</returns>
    public bool IsPrime(int number)
    {
      for (int i = 3; i <= Math.Sqrt(number); i += 2)
      {
        if (number % i == 0)
        {
          return false;
        }
      }
      return true;
    }
  }
}
