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


    Console.WriteLine();
    Console.WriteLine("pro opakovani stiskni a");
    again = Console.ReadLine();

}