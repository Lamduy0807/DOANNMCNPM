using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_2
{
    public class LoaiSPClass
    {
        public bool CheckInputLoai(string maloai, string tenloai)
        {
            if (string.IsNullOrEmpty(maloai))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(tenloai))
            {
                return false;
            }
            else
                return true;
        }
    }
}
