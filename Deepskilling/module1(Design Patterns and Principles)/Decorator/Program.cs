using System;

interface ICoffee
{
    void Cost();
}

class SimpleCoffee : ICoffee
{
    public void Cost()
    {
        Console.WriteLine("Coffee Cost = 50");
    }
}

class MilkDecorator : ICoffee
{
    private ICoffee coffee;

    public MilkDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public void Cost()
    {
        coffee.Cost();
        Console.WriteLine("Milk Added");
    }
}

class Program
{
    static void Main()
    {
        ICoffee coffee = new MilkDecorator(new SimpleCoffee());
        coffee.Cost();
    }
}
