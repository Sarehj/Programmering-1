using System;
class Uppdrag2 {
  public static void Main (string[] args) {
    
    Console.WriteLine("Gissa talet");
    Console.WriteLine("Du ska nu gissa ett tal mellan 1 och 100, så varsågod..");
    
  // Generate a random number
    Random random = new Random();
    int tal = random.Next(1, 100);

  // Hämta användaren gissa  
    Console.WriteLine("Skriv in ett tal");
    int gissa = Convert.ToInt32(Console.ReadLine());

    
  // Kontrollera om gissa är mellan 1 och 100
    if (gissa < 1 || gissa > 100)
    {
      Console.WriteLine("Du måste skriva in ett tal mellan 1 och 100!");
      Console.WriteLine("\nProgrammet är avslut");
      return; 
    }

    
  // Kontrollera om gissa är mindre än tal och dock nära
    if (gissa < tal) {
      Console.WriteLine("Ditt tal är för litet. Gissa på ett större tal");
      
      if (Math.Abs(tal - gissa) <= 3)
      {
        Console.WriteLine("Du är dock nära och det bränns");
      }
    }

    
  // Kontrollera om gissa är större än tal och dock nära
    else if (gissa > tal)
    {
      Console.WriteLine("Ditt tal är för stort. Gissa på ett mindre tal");
      
      if (Math.Abs(tal - gissa) <= 3)
      {
        Console.WriteLine("Du är dock nära");
      }
    }

    
    else
    {
      Console.WriteLine("Du gissade rätt!");
    }

    Console.WriteLine("\nProgrammet är avslut");
  }
}
