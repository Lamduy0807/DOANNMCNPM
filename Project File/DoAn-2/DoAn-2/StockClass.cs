using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_2
{
    public class StockClass
    {
        public bool CheckDatainput(string masp, string tensp, string sl, string gianhap, string giaban, string loai, string donvi, string giamgia)
        {
            if (string.IsNullOrEmpty(masp))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(tensp))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(sl))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(gianhap))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(giaban))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(loai))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(donvi))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(giamgia))
            {
                return false;
            }
            else
                return true;

        }
    }
}
