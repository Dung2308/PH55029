using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH55029
{
    internal class giaovienpoly : giaovien
    {
        private string nganhday {  get; set; }
        public giaovienpoly()
        {
            
        }
        public giaovienpoly(string nganhday,int id,string ten,double sogioday):base(id, ten, sogioday)
        {
            
            this.nganhday = nganhday;
        }
        public string getnganh
        {
            get => nganhday;
            set => nganhday = value;
        }
        public override void inthongtin()
        {
            base.inthongtin();
            Console.WriteLine($"nganh day{nganhday}");
        }
    }
}
