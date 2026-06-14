using System;

class Logger
{
    private static Logger obj;

    private Logger() { }

    public static Logger GetInstance()
    {
        if (obj == null)
            obj = new Logger();
        return obj;
    }

    public void Show()
    {
        Console.WriteLine("Singleton Object");
    }
}

class Program
{
    static void Main()
    {
        Logger.GetInstance().Show();
    }
}
