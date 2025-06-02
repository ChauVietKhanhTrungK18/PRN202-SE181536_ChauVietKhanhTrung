using OOP1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//Tạo đối tượng Cate 1
Category c1 = new();
c1.Id = 1;
c1.Name = "Nước mắm";
//Xuất thông tin bằng cách gọi hàm
c1.PrintInfor();
c1.Name = "Thuốc trị hôi nách";
Console.WriteLine("Sac khi nổi");
c1.PrintInfor();
//Sử sdungj lớp Employee
Console.WriteLine("----------------EMPLOYEE------------");
Employee e1 = new();
e1.Id = 1;
e1.Name = "Tèo";
e1.IdCard = "001";
e1.Email = "teo@gmai.com";
e1.Phone = "0985111111";
e1.PrintInfo();
Employee e2 = new()
{
    Id = 2,
    IdCard = "001",
    Name = "Tý",
    Email = "ty@hotmail.com",
    Phone = "0913452240"
};
Console.WriteLine("---------------EMPLOYEE-----------");
e2.PrintInfo();

Employee e3 = new();
Console.WriteLine("---------------EMPLOYEE-----------");
e3.PrintInfo();

//
Employee e4 = new(4, "004", "Tủn", "tun@gmail.com", "09341343432");
e4.PrintInfo();
Console.WriteLine("---------------EMPLOYEE 4 cách 2-----------");
Console.WriteLine(e4);
Console.WriteLine("==============Customer 1=============");
Customer cus1 = new Customer()
{
    Id = "Cus1",
    Name = "Nguyễn Thị A",
    Email = "att#gmail.com",
    Phone = "09353423235",
    Address="Số 1 - Đinh Tiên Hoàng - Quận 1 - HCM"
};
cus1.PrintInfor();
cus1.Address = "Số 2 - Võ Nguyên Giáp - Thủ Đức";
Console.WriteLine("Customer sau khi sửa");
cus1.PrintInfor();
