using System;

class Subscriber
{
    public void Update()
    {
        Console.WriteLine("Notification Received");
    }
}

class Program
{
    static void Main()
    {
        Subscriber s = new Subscriber();
        s.Update();
    }
}
