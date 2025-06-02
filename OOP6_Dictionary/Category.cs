using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }

        public Category()
        {
            Products = new Dictionary<int, Product>();
        }
        public override string ToString()
        {
            return $"{Id}\t{Name}";
        }
        /*
         * Khi quản lý mọi đói tượng ta đều phải đáp ứng
         * đầy đủ mọi tính năng CRUD 
         */
        public void AddProduct(Product p)
        {
            //Kiểm tra nếu Id của product chưa tồn tại thì thêm mới:
            if (p == null)
            {
                return;
            }
            if (Products.ContainsKey(p.Id))
            {
                return;
            }
            Products.Add(p.Id, p);
        }

        //Xuât toàn bộ sản phẩm 
        public void PrintAllProducts()
        {
            foreach (KeyValuePair<int, Product> kvp in Products)
            {
                Product p = kvp.Value;
                Console.WriteLine(p);
            }
        }
        //Lọc sản phẩm có giá từ min tới max
        public Dictionary<int, Product> FilterProductByPrice(double min, double max)
        {
            return Products.Where(item => item.Value.Price >= min && item.Value.Price <= max).ToDictionary<int, Product>();
        }

        //Sắp xếp sản phẩm theo đơn giá tăng dần
        public Dictionary<int, Product> SortProductByPrice()
        {
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int, Product>();

        }
        public Dictionary<int, Product> SortComplex()
        {
            return Products.OrderByDescending(item => item.Value.Price)
                           .OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }

        public bool UpdateProduct(Product p)
        {
            if (p == null)
            {
                return false;
            }
            if (!Products.ContainsKey(p.Id))
            {
                return false;
            }
            Products[p.Id] = p;
            return true;
        }

        public bool RemoveProduct(int id)
        {
            if (!Products.ContainsKey(id))
            {
                return false;
            }
            Products.Remove(id);
            return true;
        }

        public bool RemoveProductByRange(double a, double b)
        {
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
            if (a < 0 || b < 0)
            {
                return false;
            }
            foreach (KeyValuePair<int, Product> pr in Products)
            {
                if (pr.Value.Price <= b && pr.Value.Price >= a)
                {
                    Products.Remove(pr.Key);
                }
            }
            return true;
        }
    }
}
