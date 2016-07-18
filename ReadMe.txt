
I started with the basic implementation to generate prime numbers. Later used Sieve of Eratosphenes which improved the performance.

1) Basic Algorithm:
Used modulus to test the primality of each number.
Check only odd numbers as even numbers are not prime except 2.
Max Prime number in 60 secs:- 16647457.

2) Sieve of Eratosphenes:
Used both BitArray and Bool array. Bool array uses more memory than BitArray. Hence went with BitArray.
Max Prime number in 60 secs:- 23148329.

3) Sieve of Eratosphenes using Parallel.Foreach.
Max Prime number in 60 secs:- 877304471

Improvements:- 

1) sieve of atkin.
2) Threading could be used to generate prime numbers which would speed up the 1st phase of Sieve of Eratosphenes.
3) Writing to console is expensive. If we reduce the values to be displayed we can improve performance.
