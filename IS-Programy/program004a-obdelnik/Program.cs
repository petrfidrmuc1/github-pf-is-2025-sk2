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


    Console.Write("Zadej šířku obdelniku: ");
   
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.WriteLine("nezadal jsi cele cislo. zadej ho znovu: ");
    }

    Console.Write("Zadej vysku obdelniku (musi byt cele): ");
   
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.WriteLine("nezadal jsi cele cislo. zadej ho znovu: ");
    }




    for (int i = 1; i <= height ; i++)
    {
        for (int j = 1; j <= width; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("pro opakovani stiskni a");
    again = Console.ReadLine();

}