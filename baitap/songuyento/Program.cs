using System;

namespace songuyento
{
    class Program
    {
        static void Main(string[] args)
        {
           //kiem tra so nguyen to
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n < 2){
                Console.WriteLine("Khong phai so nguyen to");
            }else{
                bool lasoNT = true;
                for(int i = 2;i <= Math.Sqrt(n);i++)
                {
                    if(n % 1 == 0)
                    {
                        lasoNT = false;
                    }
                }
                if(lasoNT)
                {
                    Console.WriteLine($"{n} la so nguyen to");
                } else
                {
                    Console.WriteLine($"{n} khong phai la so nguyen to");
                }
            }
            
        }
    }
}
