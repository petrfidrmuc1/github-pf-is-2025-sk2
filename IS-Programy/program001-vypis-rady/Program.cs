string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************************************");
    Console.WriteLine("*****************vypis ciselne rady*****************");
    Console.WriteLine("****************************************************");
    Console.WriteLine("****************************************************");
    Console.WriteLine("*******************Petr Fidrmuc*********************");
    Console.WriteLine("*******************2025.10.02***********************");
    Console.WriteLine("****************************************************");
    Console.WriteLine("****************************************************");
    Console.WriteLine();

    // vstup hodnoty programu, ale spatne reseny

    Console.Write("Zadej prvni cislo rady (musi byt cele)");
    //int first = int.Parse(Console.ReadLine());


    // vstup hodnoty programu, ale spravne reseny

    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("nezadal jsi cele cislo");
    }


    Console.Write("Zadej posledni cislo rady (musi byt cele)");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("nezadal jsi cele cislo");
    }

    Console.Write("Zadej diferenci rady (musi byt cele)");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.Write("nezadal jsi cele cislo");
    }


    // Výstup zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=========================================");
    Console.WriteLine("Zadali jste tyto hodnoty:");
    Console.WriteLine("První číslo řady: {0}", first);
    Console.WriteLine("Poslední číslo řady: {0}", last);
    Console.WriteLine("Diference řady: {0}", step);
    Console.WriteLine("=========================================");
    Console.WriteLine("První číslo řady: {0}; postední číslo: {1}; diferenci: {2}", first, last, step);
    Console.WriteLine("=========================================");


    // Vypis rady
    Console.WriteLine();
    Console.WriteLine("=========================================");
    Console.WriteLine("Výpis číselné řady");

    int current = first;
    while (current <= last)
    {
        Console.WriteLine(current);
        current = current + step; // pricteni diference
    }

    

    Console.WriteLine();
    Console.WriteLine("pro opakovani programu stiskni a");
    again = Console.ReadLine();



}