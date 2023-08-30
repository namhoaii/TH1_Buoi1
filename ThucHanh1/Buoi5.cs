using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    class Buoi5
    {

        //bai1:
        public static string CatKhoanTrang(string s) => String.Join(" ", s.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

        //bai2
        public static string CatChuDau(string s) => s.Trim().Substring(0, s.IndexOf(' '));

        //bai3
        public static string CatChuCuoi(string s) => s.Trim().Substring(s.LastIndexOf(' ')+1);

        //bai4
        public static string CatOGiua(string s) => s.Trim().Substring(s.IndexOf(' ')+1, s.LastIndexOf(' ') - s.IndexOf(' '));

        //bai5
        public static int DemSoTu(string s) => s.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

        //bai 6 
        public static string TraVeTu(string s, int vt) => s.Split(' ')[vt - 1];

        //bai7
        //chuoi in hoa
        public static string ChuoiInHoa(string s) => s.ToUpper();
        //chuoi in thuong
        public static string ChuoiInThupng(string s) => s.ToLower();
        //chu cai dau
        public static string ChuCaiDau(string s) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s);
    }

}
