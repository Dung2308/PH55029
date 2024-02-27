using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH55029
{
    internal class giaovien
    {
        private int id {  get; set; }
        private string ten {  get; set; }
        private double sogioday {  get; set; }

        public giaovien()
        {
            
        }
        public giaovien(int id, string ten,double sogioday)
        {
            this.id = id;
            this.ten = ten;
            this.sogioday = sogioday;
        }
        public int getid
        {
            get => id;
            set => id = value;
        }
        public string getname
        {
            get => ten;
            set => ten = value; 
        }
        public double getSogioday
        {
            get => sogioday;
            set => sogioday = value;
        }
        public virtual void inthongtin()
        {
            Console.WriteLine($"ten:{ten}\tid:{id}\tsogioday:{sogioday}");
        }
    }
}
