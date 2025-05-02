using System;
class MainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Välkomna till denna pensionssimulator");

        //Hämta användaren namn
        Console.WriteLine("Vad heter du i förnamn?");
        string name = Console.ReadLine();

        //Hämta användaren ålder
        Console.WriteLine("Hur gammal är du?");
        int age = Convert.ToInt32(Console.ReadLine());

        //Beräknar hur många år användaren har till pension
        int kvarTillPension = 65 - age;

        //kontrollera om användaren redan har gått i pension
        if (kvarTillPension > 0)
        {
            Console.WriteLine("Hej " + name + ". Du går i pension om " + kvarTillPension + " år.");
        }
        else
        {
            Console.WriteLine($"Hej {name}, du redan gått i pension");
        }


        Console.WriteLine("Press any key to continue ...");
        Console.ReadKey();

    }
}




