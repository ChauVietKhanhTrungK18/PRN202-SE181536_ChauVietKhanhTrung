using OOP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Reuse_OOP2
{
    public static class YourUtils
    {
        public static int Tuoi(this Employee full)
        {
            return DateTime.Now.Year - full.Birthday.Year;
        } 
        public static bool checkThang(this Employee em)
        {
            return DateTime.Now.Month == em.Birthday.Month;
        }
    }
}
