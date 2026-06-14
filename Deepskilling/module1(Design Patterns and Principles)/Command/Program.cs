using System;

interface ICommand
{
    void Execute();
}

class LightOn : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Light ON");
    }
}

class Program
{
    static void Main()
    {
        ICommand cmd = new LightOn();
        cmd.Execute();
    }
}
