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

        //bài 9
        public static int FirstIndex(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == x)
                    return i;
            return -1; 
        }

        public static int LastIndex(int[] arr, int x)
        {
            for(int i = arr.Length - 1; i >= 0; i--)
                if(arr[i] == x) 
                    return i;            
            return -1;
        }

        //phân tích thừa số nguyên tố
        public static List<int> PrimeFactorization(int number)
        {
            List<int> result = new List<int>();
            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                while(number % i == 0)
                {
                    result.Add(i);
                    number /= i;
                }
            }
            if(number != 1)
            {
                result.Add(number);
            }
            return result;
        }

        //UCLN
        public static int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        //BCNN
        public static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        //Đổi chổ 2 số
        public static void SwapTwoNumber(ref int numberOne, ref int numberTwo)
        {
            int temp = numberOne;
            numberOne = numberTwo;
            numberTwo = temp;
        }

        //Đổi năm dương lịch sang năm âm lịch
        public static string LunarYear(int year)
        {
            string[] can = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            string[] chi = { "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mèo" };
            return $"{can[year % 10]} {chi[year % 12]}";
        }

        //PT Bật nhất
        /// <summary>
        ///  1 có nghiệm -1 vô số nghiệm 0 vô nghiệm  
        /// </summary>
        public static int PTBat1(float a, float b, out float x)
        {
            x = 0;
            if (a == 0)
            {
                if (b == 0)
                    return -1;
                return 0;
            }
            else
            {
                x = -b / a;
                return 1;
            }

        }

        //PT Bật 2
        /// <summary>
        /// true có nghiệm false vô nghiệm
        /// </summary>
        public static bool PTBat2(float a, float b, float c, out float x1, out float x2)
        {
            x1 = x2 = 0;
            float delta = b * b - (4 * a * c);
            if (delta < 0)
                return false;
            else if(delta == 0)
            {
                x1 = x2 = -b / (2 * a);
                return true;
            }
            else
            {
                x1 =(float) (-b + Math.Sqrt(delta)) / (2 * a);
                x2 =(float) (-b - Math.Sqrt(delta)) / (2 * a);
                return true;
            }
        }

        public static long DecimalToBinary(int n)
        {
            long binary = 0;
            int p = 0;
            while(n > 0)
            {
                binary += (n % 2) * (long)Math.Pow(10, p);
                ++p;
                n /= 2;
            }
            return binary;
        }

        public static int BinaryToDecimal(long n)
        {
            int dec = 0;
            int p = 0;
            while(n > 0)
            {
                dec += (int)(n % 10) * (int)Math.Pow(2, p);
                ++p;
                n /= 10;
            }
            return dec;
        }

        public static int DecimalToOctal(int n)
        {
            int ocl = 0;
            int p = 0;
            while(n > 0)
            {
                ocl += (n % 8) * (int)Math.Pow(10, p);
                ++p;
                n /= 8;
            }
            return ocl;
        }

        public static string DecimalToHex(int n)
        {
            if (n == 0) return "0";
            string hex = "";
            while(n > 0)
            {
                int temp = n % 16;
                hex = ((temp < 10) ? temp.ToString() : ((char)(temp - 10 + 'A')).ToString()) + hex;
                n /= 16;
            }
  
            return hex;
        }

        static void Main(string[] args)
        {
            Buoi3.GCDAndLCM(6, 20,out int a,out int b);
            Console.WriteLine($"GCD = {a} LCM = {b}");
            
            Console.ReadKey();
        }   
    }
}
