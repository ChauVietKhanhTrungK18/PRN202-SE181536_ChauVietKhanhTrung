void hinh1(int n)
{
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j == 0 || i == j || j == n - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine("\n");
    }
}
hinh1(7);