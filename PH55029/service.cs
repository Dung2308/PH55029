using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH55029
{
    internal class service
    {
        private List<giaovien> danhsachgiaovien = new List<giaovien>();
        
        public service()
        {
            danhsachgiaovien = new List<giaovien>();
          
        }
       
        public void nhapdanhsachgiaovien()
        {
            while (true)
            {
                Console.WriteLine("xin moi nhap id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("xin moi nhap ten");
                string ten = Console.ReadLine();
                Console.WriteLine("xin moi nhap so gio day");
                double sogioday = int.Parse(Console.ReadLine());
                danhsachgiaovien.Add(new giaovien(id, ten, sogioday));
                Console.WriteLine("co nhap tiep khong?(y/n)");
                string tiep = Console.ReadLine();
                if (tiep == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        public void xuatdanhsach()
        {
            foreach( giaovien giaovien in danhsachgiaovien)
            {
                giaovien.inthongtin();
            }
        }
        public void giodaykhoang()
        {
            Console.WriteLine("xin moi nhap gio max");
            double giom = int.Parse(Console.ReadLine());
            Console.WriteLine("xin moi nhap gio min");
            double giomin = int.Parse(Console.ReadLine());
            foreach(giaovien giaovien in danhsachgiaovien)
            {
                if(giaovien.getSogioday> giomin && giaovien.getSogioday < giom)
                {
                    giaovien.inthongtin();
                }
                else
                {
                    Console.WriteLine("khong co!!");
                }
            }
        }
        public void xoadoituong()
        {
            Console.WriteLine("xin moi nhap id can xoa");
            int idc = int.Parse(Console.ReadLine());
            foreach(giaovien giaovien in danhsachgiaovien)
            {
                if(giaovien.getid == idc) {
                   danhsachgiaovien.Remove(giaovien);
                }
            }
        }
        public void giaovienpoly()
        {
            while (true)
            {
                Console.WriteLine("xin moi nhap id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("xin moi nhap ten");
                string ten = Console.ReadLine();
                Console.WriteLine("xin moi nhap so gio day");
                double sogioday = int.Parse(Console.ReadLine());
                Console.WriteLine("xin moi nhap nganh day");
                string nganh = Console.ReadLine() ;
                danhsachgiaovien.Add(new giaovienpoly(nganh,id,ten,sogioday));
                Console.WriteLine("co nhap tiep khong?(y/n)");
                string tiep = Console.ReadLine();
                if (tiep == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
