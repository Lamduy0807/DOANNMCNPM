using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_2
{
    public class BanHangClass
    {
        public bool CheckData(string ma, string tensp, string sl, string dongia, string tiensp, string dvsp, string loaisp, string giamgia)
        {
            if(string.IsNullOrEmpty(ma))
            {
                return false;
            }
            else if(string.IsNullOrEmpty(tensp))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(sl))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(dongia))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(tiensp))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(dvsp))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(loaisp))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(giamgia))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
