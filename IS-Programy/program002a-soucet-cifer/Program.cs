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


    Console.Write("Zadej cele cislo ");

    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("nezadal jsi cele cislo. Zadej ho znovu: ");
    }


    int suma = 0;
    int numberBackup = number;
    int digit;
    if (number < 0)
    {
        number = -number;
    }

    while (number >= 10)
    {
        digit = number % 10; // urci zbytek
        number = (number - digit) / 10;
        Console.WriteLine("Hodnota zbytku: {0}", digit);  
        suma = suma + digit;
    }

    Console.WriteLine("Poslední zbytek = {0}", number);

    suma = suma + number;

    Console.WriteLine("Ciferný součet čísla {0} je: {1}", numberBackup, suma);
    
    Console.WriteLine();
    Console.WriteLine("pro opakovani programu stiskni a");
    again = Console.ReadLine();


}