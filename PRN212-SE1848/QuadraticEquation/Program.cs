using System.Text;

void first_degree_solution(double a, double b)
{
    if (a == 0 && b == 0)
    {
        Console.WriteLine("Vô số nghiệm");
    }
    else if (a == 0 && b != 0)
    {
        Console.WriteLine("vô nghiệm");

    }
    else
    {
        Console.WriteLine("X={0}", -b / a);
    }
}

void quadric_equation_solution(double a, double b, double c)
{
    if (a == 0)
    {
        //Phương trình bậc 1
        first_degree_solution(b, c);
    }
    else
    {
        var delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Vô nghiệm");
        }
        else if (delta == 0)
        {
            Console.WriteLine("x1=x2={0}", -b / (2 * a));
        }
        else
        {
            var x1=(-b+Math.Sqrt(delta))/(2*a);
            var x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("X1={0}\nX2={1}", x1, x2);
        }
    }
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phương trình bậc 2");
Console.WriteLine("Nhập hệ số a: ");
var a=Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập hệ số b: ");
var b = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập hệ số c: ");
var c = Double.Parse(Console.ReadLine());
Console.WriteLine("{0}X^2+{1}X+{2}=0", a, b, c);
quadric_equation_solution(a, b, c);
Console.ReadLine();