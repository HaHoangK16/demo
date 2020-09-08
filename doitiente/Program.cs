using System;
using System.Text;
namespace doitiente
{
    class Program
    {
        static void Main(string[] args)
        {
            int USD;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Đổi tiền sang VNĐ");
            Console.WriteLine("Nhập số tiền USD muốn chuyển:");
            USD = Convert.ToInt32(Console.ReadLine());


            int VND;
            VND = USD * 23000;
            Console.WriteLine("{0} USD = {1} VND ", USD, VND);
            Console.Read();
        }
    }
}