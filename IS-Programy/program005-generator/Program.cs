string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Generator pseudonahodnych cisel *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Tomáš Žižka ******************");
    Console.WriteLine("************** 6.11.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte pocet generovanych cisel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte pocet cisel znovu: ");
    }

    Console.Write("Zadejte dolni mez generovanych cisel (celé číslo): ");
    int lowerbound;
    while (!int.TryParse(Console.ReadLine(), out lowerbound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolni mez znovu: ");
    }

    Console.Write("Zadejte horni mez generovanych cisel (celé číslo): ");
    int upperbound;
    while (!int.TryParse(Console.ReadLine(), out upperbound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horni mez znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("===========================================================");
    Console.WriteLine();
    Console.WriteLine("Zadaná čísla počet: {0}, dolní mez: {1}, horní mez: {2}", n, lowerbound, upperbound);
    Console.WriteLine();
    Console.WriteLine("===========================================================");
    Console.WriteLine();

    int[] myRandNumbs = new int[n];
    Random myRandNumb = new Random();
    //Random myRandNumb = new Random(10);
    Console.WriteLine("Nahodna cisla: ");

    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerbound, upperbound);
         if (myRandNumb[i] < 0)
        {
            negativeNumbs++;
        }
        else if (myRandNumb[i] > 0)
        {
            positiveNumbs++;
        }
        else
        {
            zeros++;
        }

        if (myRandNumb[i] % 2 == 0)
        {
            evenNumbs++;
        }
        else
        {
            oddNumbs++;
        }
    
        Console.Write("{0}; ", myRandNumbs[i]);
    }






        Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}