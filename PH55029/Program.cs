using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH55029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            service service = new service();
            int c;
            do
            {
                Console.WriteLine("1.nhap thong tin giao vien");
                Console.WriteLine("2.danh sach giao vien");
                Console.WriteLine("3.tim so gio day theo khoang");
                Console.WriteLine("4.xoa doi tuong theo id");
                Console.WriteLine("5.ke thua");
                Console.WriteLine("0.thoat");
                Console.WriteLine("xin moi nhap lua chon");
                c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 0:
                        break;
                    case 1:
                        service.nhapdanhsachgiaovien();
                        break;
                    case 2:
                        service.xuatdanhsach();
                        break;
                    case 3:
                        service.giodaykhoang();
                    break;
                    case 4:
                        service.xoadoituong();
                        break;
                    case 5:
                        service.giaovienpoly();
                        break;
                }

            } while (c != 0);
            Console.ReadKey();
        }
    }
}
