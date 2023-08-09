using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    class Program
    {
        //bài 1
        public static bool IsPrime(int number)
        {
            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return number > 1;
        }

        //bài 2
        public static int SumOfIntegers(int n)
        {
            if (n == 1) return 1;
            return n + SumOfIntegers(n - 1);
        }

        // bài 3
        public static int SumOfOddNumber(int n)
        {
            if (n == 0) return 0;
            if (n % 2 == 0) return SumOfOddNumber(n - 1);
            return n + SumOfOddNumber(n - 1);
        }

        //bài 4
        public static int SumOfEvenNumber(int n)
        {
            if (n == 0) return 0;
            if (n % 2 != 0) return SumOfEvenNumber(n - 1);
            return n + SumOfEvenNumber(n - 1);
        }

        //bài 5
        public static int ReverseNumber(int number)
        {
            int result = 0;

            while(number > 0)
            {
                result = result * 10 + number % 10;
                number /= 10;
            }

            return result;
        }

        //bài 6
        public static long Factorial(int number)
        {
            if (number == 1) return 1;
            return number * Factorial(number - 1);
        }

        //bài 7

        //nhập
        public static void InputArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Vui lòng nhập một số nguyên.");
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                }
            }
        }
           
        //xuất
        public static void OutputArray(int[] arr)
        {
            Console.WriteLine("Mảng bạn đã nhập:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        //bài 8
        public static void SortArrayAsc(int[] arr)
        {
            Array.Sort(arr);
        }
        
        public static void SortArrayDesc(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhập số phần tử của mảng: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương.");
                Console.Write("Nhập số phần tử của mảng: ");
            }

            int[] arr = new int[n];
            InputArray(arr);
            SortArrayDesc(arr);
            OutputArray(arr);
            Console.ReadKey();
        }   
    }
}
