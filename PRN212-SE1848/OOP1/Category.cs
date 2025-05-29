using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public void PrintInfor()
        {
            string msg = $"{Id}\t{Name}";
            Console.WriteLine(msg);
        }
    }
}
