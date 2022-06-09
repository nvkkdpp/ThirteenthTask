using System;

namespace ThirteenthTask
{
    class IteratorBlocks
    {
        static void Main(string[] args)
        {
            MonthDays md = new MonthDays();
            Console.WriteLine("Месяцы:\n");
            foreach (string month in md)
            {
                Console.WriteLine(month);
            }
            StringChunks sc = new StringChunks();
            Console.WriteLine("Cтроки:\n");
            foreach (string chunk in sc)
            {
                Console.WriteLine(chunk);
            }
            Console.WriteLine("\nВывод в одну строку:\n");
            foreach (string chunk in sc)
            {
                Console.Write(chunk);
            }
            Console.WriteLine();
            YieldBreakEx yb = new YieldBreakEx();
            Console.WriteLine("\nПростые числа:\n");
            foreach (int prime in yb)
            {
                Console.WriteLine(prime);
            }
            EvenNumbers en = new EvenNumbers();
            Console.WriteLine("\nЧётные числа\n");
            foreach (int even in en.DescendingEvens (11, 3))
            {
                Console.WriteLine(even);
            }
            PropertyIterator prop = new PropertyIterator();
            Console.WriteLine("\nЧисла double:\n");
            foreach (double db in prop.DoubleProp)
            {
                Console.WriteLine(db);
            }
            Console.WriteLine("Нажмите на <enter> либо я разобью вам ебучку через 5 секунд");

            Console.ReadLine();

        } 

    }
    class MonthDays
    {
        string[] months =
        {
            "January 31", "February 28", "March 31", "April 30", "May 31", "June 30", "July 31", "September 30", "October 30", "November 30", "December 31"
        };
        public System.Collections.IEnumerator GetEnumerator()
        {
            foreach (string month in months)
            {
                yield return month;
            }
        }
    }
    class StringChunks
    {public System.Collections.IEnumerator GetEnumerator()
        {
            yield return "Using iterator";
            yield return "blocks";
            yield return "isn't all";
            yield return "that hard";
            yield return ".";
        }
            
    }
    class YieldBreakEx
    {
        int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
        public System.Collections.IEnumerator GetEnumerator()
        {
            foreach(int prime in primes)
            {
                if (prime > 13) yield break;
                yield return prime;
            }
        }
    }
    class EvenNumbers
    {
        public System.Collections.IEnumerable DescendingEvens(int top, int stop)
        {
            if (top % 2 != 0)
                top -= 1;
            for (int i = top; i >= stop; i -= 2)
            {
                if (i < stop) yield break;
                yield return i;
            }
        }
    }
    class PropertyIterator
    {
        double[] doubles = { 1.0, 2.0, 3.5, 4.67 };
        public System.Collections.IEnumerable DoubleProp
        {
            get
            {
                foreach(double db in doubles)
                {
                    yield return db;

                }
            }
        }
    }
}

