using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    class Buoi4
    {

        //Bài1
        public static void InputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Vui lòng nhập một số nguyên.");
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                }
            }
        }

        //Bai2
        public static void OutputArray(int[] arr)
        {
            Console.WriteLine("Mảng bạn đã nhập:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        //bài 3
        public static void SortArrayAsc(int[] arr)
        {
            Array.Sort(arr);
        }

        public static void SortArrayDesc(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        //bài 4
        public static int FindInArray(int[] arr, int x)
        {
            return Array.IndexOf(arr, x);
        }

        //Bai5
        public static int[] PrimeInArray(int[] arr)
        {
            int[] result = new int[0];
            foreach(int item in arr)
            {
               if (Program.IsPrime(item) == true)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = item;
                }

            }
            return result;
        }

        //bai6
        public static int FirstPrimary(int[] arr)
        {
            foreach(int item in arr)
            {
                if(Program.IsPrime(item) == true)
                {
                    return item;
                }
            }
            return -1;
        }

        //bai 7
        public static int LastPrimary(int[] arr)
        {
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                if (Program.IsPrime(arr[i]) == true)
                {
                    return arr[i];
                }
            }
            return -1;
        }
    }
}
