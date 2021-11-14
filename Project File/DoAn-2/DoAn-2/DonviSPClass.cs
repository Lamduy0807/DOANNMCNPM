using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_2
{
    public class DonviSPClass
    {
        public bool CheckInput(string masp, string tensp)
        {
            if (string.IsNullOrEmpty(masp))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(tensp))
            {
                return false;
            }
            else
                return true;
        }
    }
}
