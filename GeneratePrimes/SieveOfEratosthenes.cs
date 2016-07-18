using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GeneratePrimes
{
  /// <summary>
  /// Sieve Of Eratosthenes to get prime numbers. 
  /// </summary>
  public class SieveOfEratosthenes
  {
    // using a limit lower than int.MaxValue as the int was overflowing to negative.
    // it also saves a lot of time and memory usage.
    private const int RANGE = 100000000;
    private readonly BitArray _data;

    /// <summary>
    /// Initializes a new instance of<see cref="SieveOfEratosthenes"/> class.
    /// </summary>
    public SieveOfEratosthenes()
    {
      _data = new BitArray(RANGE + 1, true);
    }

    /// <summary>
    /// Generates prime numbers for a given duration.
    /// </summary>
    /// <param name="time">Duration to generate prime numbers.</param>
    public void GeneratePrimes(uint time)
    {
      Stopwatch watch = new Stopwatch();
      int maxPrime = 2;
      watch.Start();
      Parallel.ForEach(GetPrimeList(), (prime, state) =>
      {
        if (watch.Elapsed.TotalSeconds > time)
        {
          state.Stop();
        }
        if (prime > maxPrime)
          maxPrime = prime;
        Console.WriteLine(watch.Elapsed.Seconds + " : " + prime);
      });
      watch.Stop();
      Console.WriteLine("Max prime " + maxPrime);
    }

    /// <summary>
    /// Get a list of prime numbers.
    /// </summary>
    /// <returns>Prime numbers.</returns>
    private IEnumerable<int> GetPrimeList()
    {
      IList<int> primeNumbers = new List<int>();
      FillArray();
      for (int i = 1; i <= RANGE; i++)
      {
        if (_data[i])
          primeNumbers.Add(i);
      }
      return primeNumbers;
    }

    /// <summary>
    /// Identifies prime numbers in the array.
    /// </summary>
    private void FillArray()
    {
      for (int i = 2; i <= Math.Sqrt(RANGE); i++)
      {
        if (_data[i])
        {
          for (int j = i * 2; j <= RANGE; j += i)
          {
            _data[j] = false;
          }
        }
      }
    }
  }
}



