using System;
class Vektor
{
    double x;
    public Vektor()
    {
        x = 0;
    }
    public Vektor(double a)
    {
        x = a;
    }
    public static Vektor operator +(Vektor op1, Vektor op2)
    {
        Vektor op = new Vektor();
        op.x = op1.x + op2.x;
        return op;
    }
    public static Vektor operator -(Vektor op1, Vektor op2)
    {
        Vektor op = new Vektor();
        op.x = op1.x - op2.x;
        return op;
    }
    public static double operator *(Vektor op1, Vektor op2)
    {
        double s;
        s = op1.x * op2.x;
        return s;
    }
    public void Natija()
    {
        Console.Write(x+" ");
    }
}
class Programm
{
    public static void Main()
    {
        Console.Write("vektor argumentlari sonini kiriting: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] vektor1 = new double[n];
        double[] vektor2 = new double[n];
        Console.WriteLine("1 - vektor argumentlari kiriting: ");
        for (int i=0;i<n;i++)
        {
            vektor1[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("2 - vektor argumentlari kiriting: ");
        for (int i = 0; i < n; i++)
        {
            vektor2[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("vektorlar yig'indisi: ");
        Console.Write("(");
        for(int i=0;i<n;i++)
        {
            Vektor v1 = new Vektor(vektor1[i]);
            Vektor v2 = new Vektor(vektor2[i]);
            Vektor v3;
            v3 = v1 + v2;
            v3.Natija();
        }
        Console.Write(")");
        Console.WriteLine("vektorlar ayirmasi: ");
        Console.Write("(");
        for (int i = 0; i < n; i++)
        {
            Vektor v1 = new Vektor(vektor1[i]);
            Vektor v2 = new Vektor(vektor2[i]);
            Vektor v3;
            v3 = v1 - v2;
            v3.Natija();
        }
        Console.Write(")");
        Console.WriteLine("vektorlar ko'paytmasi: ");
        double s = 0;
        for (int i = 0; i < n; i++)
        {
            Vektor v1 = new Vektor(vektor1[i]);
            Vektor v2 = new Vektor(vektor2[i]);
            s += v1 * v2;
        }
        Console.Write(s);
        Console.ReadKey();
    }
}
