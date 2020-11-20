using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Euler
{
    public class ProblemsLevel1
    {
        public int SumOfMults3Or5(int maxInteger)
        {
            int total = 0;

            for (int i = 1; i < maxInteger; i++)
            {
                if (i%3==0 || i%5==0)
                {
                    total += i;
                }
            }

            return total;
        }

        public int EvenFibs(int maxInteger)
        {
            int[] fib = new int[maxInteger];
            var fibList = new List<int>{2};

            fib[0] = 1;
            fib[1] = 2;

            for (int i = 2; i < maxInteger; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];

                if (fib[i] > maxInteger) { break; }
                
                if (fib[i]%2==0) { fibList.Add(fib[i]); }
            }

            return fibList.Sum();
        }

        public long LargestPrimeFactor(long number)
        {
            var primes = new List<long>();

            for (int div = 2; div <= Math.Sqrt(number); div++)
            {
                if (number % div == 0)
                {
                    primes.Add(div);
                    number = number / div;
                }
            }
            primes.Add(number);
            
            return primes.Max();
        }

        public bool PalindromeCheck(int num)
        {
            // Palindrome Logic
            string numStr = num.ToString();
            string numLeft = numStr.Substring(0, numStr.Length/ 2);
            string numRight = numStr.Length % 2 == 0 ? numStr.Substring(numStr.Length/ 2) : numStr.Substring(numStr.Length/ 2 + 1);
            string numRReverse = String.Join("",numRight.ToArray().Reverse());
            if (int.Parse(numLeft) == int.Parse(numRReverse))
            {
                return true;
            }
            return false;
        }

        public int LargestPalindromeProduct(int min, int max)
        {
            var palindromList = new List<int>();

            int a = min;
            int b = min;

            for (int i = min; i <= max; i++)
            {
                for (int j = min; j <= max; j++)
                {
                    if (j == max && PalindromeCheck(i*j))
                    {
                        palindromList.Add(i*j);
                        Console.WriteLine($"{i}*{j} = {i*j}");
                        break;
                    }
                    
                    if (b == max && !PalindromeCheck(i*j))
                    {
                        break;
                    }
                    if (PalindromeCheck(i*j))
                    {
                        palindromList.Add(i*j);
                        Console.WriteLine($"{i}*{j} = {i*j}");
                    }
                }
            }

            return palindromList.Max();
        }

        public bool ModuloAll(int num, int max)
        {
            var range = Enumerable.Range(1, max).Select(x => num % x);

            return !range.Any(x => x > 0);
        }

        public int SmallestMultiple(int min, int max)
        {
            while (!ModuloAll(min,max))
            {
                min++;
            }

            return min;
        }

        public int SumSquareDifference(int max)
        {
            int sumOfSquares = Enumerable.Range(1, max).Select(x => x * x).Sum();
            int squareOfSum = Enumerable.Range(1,max).Sum();

            return squareOfSum*squareOfSum - sumOfSquares;
        }

        public bool IsPrime(int num)
        {
            if (num == 2)
            {
                return true;
            }
            
            var range = Enumerable.Range(2, (int) Math.Floor(Math.Sqrt(num))).Select(x => num % x);

            return range.All(x => x != 0);
        }

        public int NthPrimeNumber(int max)
        {
            int count = 0;
            int num = 2;

            while (count < max)
            {
                if (IsPrime(num))
                {
                    count++;
                    num++;
                }
                else
                {
                    num++;
                }
            }

            return num-1;
        }
        
        public string SubString(string str, int x, int max)
        {
            return str.Substring(x, max);
        }

        public long LargestProductInSeries(int max)
        {
            long largest = 0;
            
            // There /has/ to be a better way... File I/O? That seems a bit overkill.
            var number = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

            // If substring contains a 0, skip and move on.

            for (int i = 0; i < number.Length-max; i++)
            {
                var numList = SubString(number, i, max).ToList().Select(x => long.Parse(x.ToString())); // This needs to convert the substring to a list of int.

                if (numList.Contains('0'))
                {
                    continue;
                }

                long product = numList.Aggregate((total, next) => total * next);

                if (product > largest)
                {
                    largest = product;
                    Console.WriteLine($"Newest largest is at {i} out of {number.Length} and equal to {largest}. It's list is {String.Join(" ", numList)}.");
                }
            }

            return largest;
        }

        public int SpecialPythagTrip(int max)
        {
            // a < b < c ; a^2 + b^2 = c^2 ; a + b + c = max ; 
            // a*b mod 12 == 0 ; a*b*c mod 60 == 0 ;
            // no repeats ; 

            if (true)
            {

            }

            return 0;
        }
    }
}