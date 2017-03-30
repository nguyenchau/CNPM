using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDiem
{
    class Diem
    {
        private static double ChuyenCan, GiuaKi, CuoiKi;
        
        public static double CHUYENCAN
        {
            get { return ChuyenCan; }
            set { ChuyenCan = value; }
        }
        public static double GIUAKI
        {
            get { return GiuaKi; }
            set { GiuaKi = value; }
        }
        public static double CUOIKI
        {
            get { return CuoiKi; }
            set { CuoiKi = value; }
        }
        public static bool KiemTraDiem()
        {
            if (ChuyenCan <= 10 && (GiuaKi <= 10) && (CuoiKi <= 10))
            {
                return true;
            }
            return false;
        }
        public static double TinhDiemThang10()
        {
            return (0.6 * CuoiKi + 0.2 * GiuaKi + 0.2 * ChuyenCan);
        }
        public static string TinhDiemChu()
        {
            if ((0.6 * CuoiKi + 0.2 * GiuaKi + 0.2 * ChuyenCan) < 4)
                return "F";
            if ((0.6 * CuoiKi + 0.2 * GiuaKi + 0.2 * ChuyenCan) < 5.5)
                return "D";
            if ((0.6 * CuoiKi + 0.2 * GiuaKi + 0.2 * ChuyenCan) < 6.5)
                return "C";
            if ((0.6 * CuoiKi + 0.2 * GiuaKi + 0.2 * ChuyenCan) < 8)
                return "B";
            else
                return "A";
        }
        public static  string  Note()
        {
            if ((0.6 * CuoiKi + 0.2 * GiuaKi + 0.2 * ChuyenCan) < 4)
                return " Xếp loại F, Good luck next time!";
            if ((0.6 * CuoiKi + 0.2 * GiuaKi + 0.2 * ChuyenCan) < 5.5)
                return "Xếp loại D, Good luck next time!";
            if ((0.6 * CuoiKi + 0.2 * GiuaKi + 0.2 * ChuyenCan) < 6.5)
                return "Xếp loại C, Well done!";
            if ((0.6 * CuoiKi + 0.2 * GiuaKi + 0.2 * ChuyenCan) < 8)
                return "Xếp loại B, Goodjob !";
            else
                return "Xếp loại A, Goodjob !";
        }

    }
    
}
