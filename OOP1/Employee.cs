using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Employee
    {
        
        #region Nhóm cac thuộc tính của employee
        public int _id;
        public string _id_card;
        public string _name;
        public string _email;
        public string _phone;
        #endregion
        #region nhóm các constructor 
        public Employee()
        {
            this._id = 0;
            this._email = "obamagmail.com";
            this._id_card = "000";
            this._phone = "12345";

        }

        public Employee(int _id, string _id_card, string _name, string _email, string _phone)
        {
            this._id = _id;
            this._id_card = _id_card;
            this._name = _name;
            this._email = _email;
            this._phone = _phone;
        }
        #endregion
        #region nhóm các properties của employee
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string IdCard
        {
            get { return _id_card; }
            set { _id_card = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        #endregion
        #region Nhóm các phương thức của employee
        public void PrintInfo()
        {
            Console.WriteLine($"{Id}\t{IdCard}\t{Name}\t{Email}\t{Phone}");
        }
        public override string ToString()
        {
            return $"{Id}\t{IdCard}\t{Name}\t{Email}\t{Phone}";
        }
        #endregion
    }
}
