using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************************************");
    Console.WriteLine("****************serazeni dvou cisel*****************");
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

    int pom;
    Console.WriteLine();
    if (a > b)
    {
        pom = a;
        a = b;
        b = pom;
        Console.WriteLine("Došlo k prohození čísel")
    }
    

    Console.WriteLine("========================================================");
    Console.WriteLine($"Seřazená čísla: {a}, {b}");
    Console.WriteLine("========================================================");






    Console.WriteLine();
    Console.WriteLine("pro opakovani stiskni a");
    again = Console.ReadLine();

}