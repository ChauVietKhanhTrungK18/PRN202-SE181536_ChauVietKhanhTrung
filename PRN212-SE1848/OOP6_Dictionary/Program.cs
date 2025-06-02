using OOP6_Dictionary;
using System.Runtime.Intrinsics.Arm;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nước ngọt";
Product p1=new Product();
p1.Id = 1;
p1.Name = "Pepsi";
p1.Price = 30;
p1.Quantity = 20;
c1.AddProduct(p1);

Product p2 = new Product();
p2.Id = 2;
p2.Name = "Coca";
p2.Price = 25;
p2.Quantity = 15;
c1.AddProduct(p2);


Product p3 = new Product();
p3.Id = 3;
p3.Name = "Sting";
p3.Price = 15;
p3.Quantity = 9;
c1.AddProduct(p3);


Product p4 = new Product();
p4.Id = 4;
p4.Name = "Miranda";
p4.Price = 10;
p4.Quantity = 30;
c1.AddProduct(p4);


Product p5 = new Product();
p5.Id = 5;
p5.Name = "Coca";
p5.Price = 10;
p5.Quantity = 25;
c1.AddProduct(p5);

Console.WriteLine("-------------Thông tin danh mục---------------");
Console.WriteLine(c1);
Console.WriteLine("-------------Danh sách sản phẩm---------------");
c1.PrintAllProducts();

double min_price = 10;
double max_price = 20;
Dictionary<int,Product> products_by_price=c1.FilterProductByPrice(min_price, max_price);
Console.WriteLine($"Danh sách sản phẩm có giá từ {min_price} tới {max_price} ");
foreach(KeyValuePair<int,Product> kvp in products_by_price)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}
Dictionary<int,Product> sorted_products=c1.SortProductByPrice();
Console.WriteLine("-----------Danh sách sản phẩm sau khi sắp xếp Giá tăng dần");
foreach (KeyValuePair<int, Product> kvp in sorted_products)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sort_complex = c1.SortProductByPrice();
Console.WriteLine("-----------Danh sách sản phẩm sau khi sắp xếp Giá tăng dần");
foreach (KeyValuePair<int, Product> kvp in sort_complex)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

p5.Name = "Fanta";
p5.Price = 80;
p5.Quantity = 17;
bool ret = c1.UpdateProduct(p5);
Console.WriteLine("-----Sản phẩm sau khi cập nhập-----");
c1.PrintAllProducts();
Console.WriteLine("=======================");
int id = 5;
ret = c1.RemoveProduct(id);
if (ret == false)
{
    Console.WriteLine($"Không tìm thấy mã {id} để xóa");

}
else {
    Console.WriteLine($"Đã xóa thành công sản phẩm có mã {id}");
    Console.WriteLine("---Sản phẩm sau khi xóa---:");
    c1.PrintAllProducts();
}
Console.WriteLine("=========================");

//Viết hàm cho phép xóa các sản phẩm có đơn giá từ a đến b
Console.WriteLine("trước khi xóa");
c1.PrintAllProducts();
double a = 15;
double b = 25;

Console.WriteLine($"Các sản phẩm sau khi xóa đơn giá từ {a} đến {b} là: ");
bool ret2=c1.RemoveProductByRange(a, b);
if (ret2 == true)
{
    c1.PrintAllProducts();
}
LinkedList<Category> categories = new LinkedList<Category>();
categories.AddLast(c1);
Category c2 = new Category();
c2.Id = 2;
c2.Name = "Bia các loại";
c2.AddProduct(new Product { Id = 6, Name = "Bia Hà Nội", Price = 20, Quantity = 50 });
c2.AddProduct(new Product { Id = 7, Name = "333", Quantity = 20, Price = 25 });
c2.AddProduct(new Product { Id = 8, Name = "Tiger", Quantity = 30, Price = 30 });
categories.AddFirst(c2);
Console.WriteLine("------Danh sách toàn bộ các sản phẩm theo danh mục");
foreach(Category c in categories)
{
    Console.WriteLine(c);
    Console.WriteLine("-------------");
    c.PrintAllProducts();
    Console.WriteLine("-------------");
}