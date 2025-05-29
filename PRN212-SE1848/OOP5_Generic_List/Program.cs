/*
 * Sử dung tính năng Generic List để quản lý nhân sự với đầu đủ 
 * Tính năng CRUD
 * C->CREATE --> Tạo mới dữ liệu
 * R->Read/Retrieve->Xem, lọc tìm kiếm ,sắp xếp ,thống kê...
 * U->Update->Sửa dữ liệu
 * D->Delete -> Xóa dữ liệu
 */
//Câu 1: tạo 5 nhân viên , 3 nhân viên chính thức, 2 nhân viên thời vụ

using OOP2;
using System.Text;

List<Employee> employees = new List<Employee>();
FulltimeEmployee f1 = new()
{
    Id = 1,
    IdCard = "123",
    Name = "Name 1",
    Birthday = new DateTime(1990, 1, 1),
};
employees.Add(f1);

FulltimeEmployee f2 = new()
{
    Id = 2,
    IdCard = "456",
    Name = "Name 2",
    Birthday = new DateTime(1990, 11, 12),
};
employees.Add(f2);

FulltimeEmployee f3 = new()
{
    Id = 3,
    IdCard = "789",
    Name = "Name 3",
    Birthday = new DateTime(1980, 12, 15),
};
employees.Add(f3);

ParttimeEmployee p1 = new()
{
    Id = 4,
    IdCard = "111",
    Name = "Name 4",
    Birthday = new DateTime(1995, 5, 20),
    WorkingHour=11
};
employees.Add(p1);

ParttimeEmployee p2 = new()
{
    Id = 5,
    IdCard = "222",
    Name = "Name 5",
    Birthday = new DateTime(1985, 5, 20),
    WorkingHour=3
};
employees.Add(p2);
Console.OutputEncoding = Encoding.UTF8;
//Câu 2: R->Xuất toàn bộ nhân sự
Console.WriteLine("Câu 2: R->Xuất toàn bộ nhân sự:");
//Cách 1:
employees.ForEach(employees=>Console.WriteLine(employees));

//Câu 3: R->Lọc ra các nhân sự là chính thức
//Cachs1 
List<FulltimeEmployee> fe_list = employees.OfType<FulltimeEmployee>().ToList();
Console.WriteLine("Câu 3: Lọc ra các nhân sự là chính thức");
foreach(FulltimeEmployee fe in fe_list)
{
    Console.WriteLine(fe);
}
//Câu 4: Tổng lương nhân viên chính thức
double fe_sum_salary = fe_list.Sum(e => e.calSalary());
Console.WriteLine("Câu 4: Tổng lương nhân viên chính thức");
Console.WriteLine(fe_sum_salary);

//Câu 5: tổng lương nhân viên thời vụ
double pe_sum_salary = employees.OfType<ParttimeEmployee>().Sum(e => e.calSalary());
Console.WriteLine("Câu 5: tổng lương nhân viên thời vụ");
Console.WriteLine(pe_sum_salary);

//Xoa va sửa dữ liệu