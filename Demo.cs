using System;

class Demo
{
    private int n1;             
    private static int n2 = 20;

    public int N1
    {
        get { return n1; }
        set { n1 = value; }
    }

    public static int N2
    {
        get { return n2; }
    }

    public Demo(int num1)
    {
        n1 = num1;
    }

    public int Add()
    {
        return n1 + n2;
    }

    public int Multiply()
    {
        return n1 * n2;
    }
}

class DemoImplemented
{
    static void Main(string[] args)
    {
        Demo d = new Demo(10);

        Console.WriteLine("n1 = " + d.N1);
        Console.WriteLine("n2 = " + Demo.N2);

        Console.WriteLine("Addition: " + d.Add());
        Console.WriteLine("Multiplication: " + d.Multiply());
    }
}
