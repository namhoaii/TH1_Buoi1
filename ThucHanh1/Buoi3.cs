using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    class Buoi3
    {
        //Bài 1: UCLN
        public static int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        //Bài 2: BCNN
        public static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        //Bài 3: Tìm GCD LCM
        public static void GCDAndLCM(int a, int b, out int gcd, out int lcm)
        {
            gcd = GCD(a, b);
            lcm = LCM(a, b);
        }

        //Bài 4: Thập phân sang nhị phân
        public static long DecimalToBinary(int n)
        {
            long binary = 0;
            int p = 0;
            while (n > 0)
            {
                binary += (n % 2) * (long)Math.Pow(10, p);
                ++p;
                n /= 2;
            }
            return binary;
        }

        //Bài 5: Nhị sang thập
        public static int BinaryToDecimal(long n)
        {
            int dec = 0;
            int p = 0;
            while (n > 0)
            {
                dec += (int)(n % 10) * (int)Math.Pow(2, p);
                ++p;
                n /= 10;
            }
            return dec;
        }

        //Bài 6: Kiểm tra số nhị phân

        public static bool isBinary(long n)
        {
            while(n > 0)
            {
                int temp = (int)n % 10;
                if (temp != 0 && temp != 1)
                {
                    return false;
                }
                n /= 10;
            }
            return true;
        }

        //Bài 7: Thập sang bát
        public static int DecimalToOctal(int n)
        {
            int ocl = 0;
            int p = 0;
            while (n > 0)
            {
                ocl += (n % 8) * (int)Math.Pow(10, p);
                ++p;
                n /= 8;
            }
            return ocl;
        }

        //Bài 8: Bát sang thập

        public static int OctalToDecimal(int n)
        {
            int dec = 0;
            int p = 0;
            while(n > 0)
            {
                dec += (n % 10) * (int)Math.Pow(8, p);
                ++p;
                n /= 10;
            }
            return dec;
        }

        //Bài 9: Thập sang thập lục
        public static string DecimalToHex(int n)
        {
            if (n == 0) return "0";
            string hex = "";
            while (n > 0)
            {
                int temp = n % 16;
                hex = ((temp < 10) ? temp.ToString() : ((char)(temp - 10 + 'A')).ToString()) + hex;
                n /= 16;
            }

            return hex;
        }

        //Bài 10: Thập lục sang thập phân
        public static int HexToDecimal(string n)
        {
            int result = 0;
            int power = 0;
            for(int i = n.Length - 1; i >= 0; i--)
            {
                int temp;
                if(n[i] >= 48 && n[i] <= 57)
                {
                    temp = (int)n[i] - 48;
                }
                else
                {
                    temp = 10 + (int)(n[i] - 65);
                }
                temp = temp * (int)Math.Pow(16, power);
                result += temp;
                ++power;
            }
            return result;
        }
    }
}
