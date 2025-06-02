using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Employee
    {
        public Employee()
        {
            
        }
        public Employee(int id, string idCard, string name, DateTime birthday)
        {
            Id = id;
            IdCard = idCard;
            Name = name;
            Birthday = birthday;
        }
        public int Id { set; get; }
        public string IdCard { set; get; }
        public string Name { set; get; }
        public DateTime Birthday { set; get; }
        public virtual double calSalary()
        {
            return 4000000;
        }
        public override string ToString()
        {
            return Id+"\t"+IdCard+"\t"+Name+"\t"+Birthday.ToString("dd/MM/yyyy")+"\t"+calSalary();
        }
    }
}
