using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class GenericDemo
{
    public GenericDemo()
    {
        StringDataBase<String> obj = new StringDataBase<String>();
        obj.Add("Hello");
        obj.Add("World");
        obj.addTwoNumbers(3.5, 5.7);
        obj.printList();
        obj.swap<int>(5, 10);
        obj.swap<String>("Welcome", "Home");
    }
}

public class StringDataBase<T>
{
    List<T> elements = new List<T>();

    public void Add(T value)
    {
        elements.Add(value);
    }

    public void addTwoNumbers<T>(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        T Sum = x + y;
        Console.WriteLine(Sum);
    }

    public void printList()
    {
        foreach (T value in elements)
        {
            Console.WriteLine(value);
        }
    }

    public void swap<T1>(T1 a, T1 b)
    {
        Console.WriteLine($"After swapping, a = {a}, b ={b}");
        T1 temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"After swapping, a = {a}, b ={b}");
    }

}
