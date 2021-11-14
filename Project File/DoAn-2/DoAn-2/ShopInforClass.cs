using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_2
{
    public class ShopInforClass
    {
        public bool CheckInformation(string ten, string sdt, string diachi, string loichao)
        {
            if (string.IsNullOrEmpty(ten))
                return false;
            else if (string.IsNullOrEmpty(sdt))
                return false;
            else if (string.IsNullOrEmpty(diachi))
                return false;
            else if (string.IsNullOrEmpty(loichao))
                return false;
            else
                return true;
        }
    }
}
