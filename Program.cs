using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un año: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine("{0} es un año bisiesto.", year);
        }
        else
        {
            Console.WriteLine("{0} no es un año bisiesto.", year);
        }
    }
}
