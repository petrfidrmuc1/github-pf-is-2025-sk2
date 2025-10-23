using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************************************");
    Console.WriteLine("**************nejvetsi ze tri cisel*****************");
    Console.WriteLine("****************************************************");
    Console.WriteLine("****************************************************");
    Console.WriteLine("*******************Petr Fidrmuc*********************");
    Console.WriteLine("********************2025.10.23**********************");
    Console.WriteLine("****************************************************");
    Console.WriteLine("****************************************************");
    Console.WriteLine();


    Console.Write("Zadej cislo A (musi byt cele): ");
   
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.WriteLine("nezadal jsi cele cislo. zadej ho znovu: ");
    }

    Console.Write("Zadej cislo B (musi byt cele): ");
   
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.WriteLine("nezadal jsi cele cislo. zadej ho znovu: ");
    }

    Console.Write("Zadej cislo C (musi byt cele): ");

    int c;
    while (!int.TryParse(Console.ReadLine(), out c)) 
    {
        Console.WriteLine("nezadal jsi cele cislo. zadej ho znovu: ");
    }

    if (a > b)
    {
        if (a > c)
        {
            Console.WriteLine($"Největší je: {a}");
        }
        else
        {
            Console.WriteLine($"Největší je: {c}");
        }
    }
    
    else
    {
        if (b > c)
        {
            Console.WriteLine($"Největší je: {b}");
        }
        else
        {
            Console.WriteLine($"Největší je: {c}");
        }
    }




    Console.WriteLine();
    Console.WriteLine("pro opakovani stiskni a");
    again = Console.ReadLine();

}