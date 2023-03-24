using System;

interface lShare
{
    void Draw(int size);
}

class VerticalLine : lShare
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("|");
        }
    }
}

class HorizontalLine : lShare
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}

class Square : lShare
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        VerticalLine vl = new VerticalLine();
        HorizontalLine hl = new HorizontalLine();
        Square sq = new Square();

        Console.WriteLine("Vertical Line:");
        vl.Draw(5);

        Console.WriteLine("Horizontal Line:");
        hl.Draw(7);

        Console.WriteLine("Square:");
        sq.Draw(4);

        Console.ReadKey();
    }
}