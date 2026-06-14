using System;

interface IPrinter
{
    void Print();
}

class Printer : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }
}

class Program
{
    static void Main()
    {
        Printer p = new Printer();
        p.Print();
    }
}
