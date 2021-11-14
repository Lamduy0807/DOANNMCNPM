using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DoAn_2
{
    public class LoginClass
    {
        public bool Login(string un, string pass)
        {
            SqlConnection connect = ClassKetnoi.connect;
            string querynv = "Select * From nhanvien where usernv ='" + un + "' and passnv='" + pass + "' ";
            SqlDataAdapter sqldata = new SqlDataAdapter(querynv, connect);
            DataTable datatb1 = new DataTable();
            sqldata.Fill(datatb1);
            if (datatb1.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckData(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            else
                return true;
        }
    }
}
