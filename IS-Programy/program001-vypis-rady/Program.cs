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
        Console.WriteLine("nezadal jsi cele cislo");
    }


    Console.WriteLine();
    Console.WriteLine("pro opakovani stiskni a");
    again = Console.ReadLine();

}