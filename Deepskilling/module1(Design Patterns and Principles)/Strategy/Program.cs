using System;

interface IPayment
{
    void Pay();
}

class UPI : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paid using UPI");
    }
}

class Program
{
    static void Main()
    {
        IPayment payment = new UPI();
        payment.Pay();
    }
}
