using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_2
{
    public class EmployeeInformation
    {
        public bool CheckInput( string tk, string ten, string mk)
        {
            if (string.IsNullOrEmpty(tk))
                return false;
            else if (string.IsNullOrEmpty(ten))
                return false;
            else if (string.IsNullOrEmpty(mk))
                return false;
            else
                return true;
        }
    }
}
