using System;
namespace test
{
    public class BaiTap
    {
        public static void  BaiTap01()
        {
            int[] array = { 1, 46, 31, 3, 2, -1, 0, 4 };
            int number = array[0];
            foreach (int n in array)
            {
                if (n > number)
                {
                    number = n;
                }
            }
            Console.WriteLine("So lon nhat la:" + number);
        }
        public static void BaiTap02()
        {
            Random rand = new Random();
            int randnumber = rand.Next(1, 7);
            Console.WriteLine("Nhap so ban doan (1,6):");
            int n;

            if (int.TryParse(Console.ReadLine(), out n) && n >= 1 && n <= 6)
            {
                if (n == randnumber)
                {
                    Console.WriteLine("Ban Thang!");
                }
                else
                {
                    Console.WriteLine("Ban Thua !!!!!!!!");
                    Console.WriteLine("So radom la " + randnumber);
                }
            }
            else
            {
                Console.WriteLine("Doan trong khoang tu 1 - 6!!");
            }
        }

    }
}
