﻿using System;

class Electric
{
    double voltage;
    double resistance;

    public Electric(double v, double r)
    {
        voltage = v;
        resistance = r;
    }

    public double CalculateCurrent()
    {
        if (resistance == 0)
        {
            return 0;
        }
        return voltage / resistance;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введiть напругу (В): ");
        double v = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть опiр (Ом): ");
        double r = Convert.ToDouble(Console.ReadLine());

        Electric c = new Electric(v, r);
        double current = c.CalculateCurrent();

        if (r == 0)
        {
            Console.WriteLine("Опiр не може бути нульовим. Неможливо обчислити струм.");
        }
        else
        {
            Console.WriteLine($"Сила струму: {current} А");
        }
    }
}
