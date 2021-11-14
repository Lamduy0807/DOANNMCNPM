using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_2
{
    public class BanHangTTClass
    {
        public bool CheckTT(string TT)
        {
            if (string.IsNullOrEmpty(TT))
            {
                return false;
            }
            return true;
        }
    }
}
