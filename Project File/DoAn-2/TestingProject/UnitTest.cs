using NUnit.Framework;
using DoAn_2;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace TestingProject
{
    public class Tests
    {
        
        [TestCase("admin","111", true)]
        [TestCase("", "111", false)]
        [TestCase("admin", "", false)]
        [TestCase("", "", false)]
        public void LoginTest(string un, string pass, bool result)
        {
            
            LoginClass login = new LoginClass();
     
            Assert.AreEqual(login.CheckData(un, pass), result);
        }



        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika","1", "9000","9000","Gói", "kẹo ngọt","0",true)]
        [TestCase("", "Kẹo trái cây bốn mùa Bibika", "1", "9000", "9000", "Gói", "kẹo ngọt", "0", false)]
        [TestCase("Kn15", "", "1", "9000", "9000", "Gói", "kẹo ngọt", "0", false)]
        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika", "", "9000", "9000", "Gói", "kẹo ngọt", "0", false)]
        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika", "1", "", "9000", "Gói", "kẹo ngọt", "0", false)]
        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika", "1", "9000", "", "Gói", "kẹo ngọt", "0", false)]
        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika", "1", "9000", "9000", "", "kẹo ngọt", "0", false)]
        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika", "1", "9000", "9000", "Gói", "", "0", false)]
        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika", "1", "9000", "9000", "Gói", "kẹo ngọt", "", false)]
        public void SelingTest(string ma, string tensp, string sl, string dongia, string tiensp, string dvsp, string loaisp, string giamgia, bool result)
        {
            BanHangClass bh = new BanHangClass();
            Assert.AreEqual(bh.CheckData(ma,tensp,sl,dongia,tiensp,dvsp,loaisp,giamgia), result);
        }


        [TestCase("", false)]
        [TestCase("50000",  true)]
        public void ThanhToanTest(string money,  bool result)
        {

            BanHangTTClass tt = new BanHangTTClass();

            Assert.AreEqual(tt.CheckTT(money), result);
        }


        [TestCase("1", "Gói", true)]
        [TestCase("1", "", false)]
        [TestCase("", "Giói", false)]
        [TestCase("", "", false)]
        public void DonViTest(string madv, string ten, bool result)
        {

            DonviSPClass dv = new DonviSPClass();

            Assert.AreEqual(dv.CheckInput(madv, ten), result);
        }


        [TestCase("1", "Kẹo Ngọt", true)]
        [TestCase("1", "", false)]
        [TestCase("", "Kẹo Ngọt", false)]
        [TestCase("", "", false)]
        public void LoaiSPTest(string maloai, string tenloai, bool result)
        {
            LoaiSPClass l = new LoaiSPClass();
            Assert.AreEqual(l.CheckInputLoai(maloai, tenloai), result);

        }

        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika", "1", "9000", "19000", "kẹo ngọt", "Gói","0", true)]
        [TestCase("", "Kẹo trái cây bốn mùa Bibika", "1", "9000", "19000", "kẹo ngọt", "Gói", "0", false)]
        [TestCase("Kn15", "", "1", "9000", "19000", "kẹo ngọt", "Gói", "0", false)]
        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika", "", "9000", "19000", "kẹo ngọt", "Gói", "0", false)]
        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika", "1", "", "19000", "kẹo ngọt", "Gói", "0", false)]
        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika", "1", "9000", "", "kẹo ngọt", "Gói", "0", false)]
        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika", "1", "9000", "19000", "", "Gói", "0", false)]
        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika", "1", "9000", "19000", "kẹo ngọt", "", "0", false)]
        [TestCase("Kn15", "Kẹo trái cây bốn mùa Bibika", "1", "9000", "19000", "kẹo ngọt", "Gói", "", false)]

        public void StockTest(string masp, string tensp, string sl, string gianhap, string giaban, string loai, string donvi, string giamgia,bool result)
        {
            StockClass s = new StockClass();
            Assert.AreEqual(s.CheckDatainput(masp, tensp, sl, gianhap, giaban, loai, donvi, giamgia), result);
        }


        [TestCase("MaxFood", "0909090909", "vietnam", "Welcome to maxfood", true)]
        [TestCase("", "0909090909", "vietnam", "Welcome to maxfood", false)]
        [TestCase("MaxFood", "", "vietnam", "Welcome to maxfood", false)]
        [TestCase("MaxFood", "0909090909", "", "Welcome to maxfood", false)]
        [TestCase("MaxFood", "0909090909", "vietnam", "", false)]

        public void ShopInformationTest(string ten, string sdt, string diachi, string loichao, bool result)
        {
            ShopInforClass l = new ShopInforClass();
            Assert.AreEqual(l.CheckInformation(ten, sdt,diachi,loichao), result);

        }
        [TestCase( "nguyenvana", "Nguyên Văn A", "111", true)]
        [TestCase( "","Nguyên Văn A", "111", false)]
        [TestCase( "nguyenvana", "", "111", false)]
        [TestCase( "nguyenvana", "Nguyên Văn A", "", false)]

        public void EmployeeInformationTest( string tk, string ten, string mk, bool result)
        {
            EmployeeInformation l = new EmployeeInformation();
            Assert.AreEqual(l.CheckInput(tk, ten, mk), result);

        }

    }
}