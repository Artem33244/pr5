using System;
using System.Collections.Generic;

interface IHello
{
    void SayHello();
}

class HelloInEnglish : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}

class HelloInFrench : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Bonjour!");
    }
}

class HelloInRussian : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Привет!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IList<IHello> helloList = new List<IHello>()
        {
            new HelloInEnglish(),
            new HelloInFrench(),
            new HelloInRussian()
        };

        foreach (IHello hello in helloList)
        {
            hello.SayHello();
        }

        Console.ReadKey();
    }
}