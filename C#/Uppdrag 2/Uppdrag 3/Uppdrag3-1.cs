using System;
class Uppdrag3_1 {
  public static void Main (string[] args) {
    
  
    // Håller reda på om spelaren vill spela igen
    bool playAgain = true;
    int bestRecord = int.MaxValue; // Bästa resultat
    

    while(playAgain){

      Console.WriteLine("Gissa talet");
      Console.WriteLine("Du ska nu gissa ett tal mellan 1 och 100, så varsågod..");
    
    // Generate a random number
      Random random = new Random();
      int num = random.Next(1, 100); 
    
      int guess = 0;
      int guessCount = 0; // Räknar antalet gissningar

      
    // Håller reda på om gissningen var korrekt
      bool correctGuess = false;
    
      do 
      {

        // Hämta användaren gissa  
        Console.WriteLine("\nSkriv in ett tal");
        guess = Convert.ToInt32(Console.ReadLine());
        
        
        // Kontrollera om gissa är mellan 1 och 100
        if (guess < 1 || guess > 100)
        {
          Console.WriteLine("Du måste skriva in ett tal mellan 1 och 100!");
          continue; 
        }


        guessCount++;
        
        // Kontrollera om gissa är mindre än tal och dock nära
        if (guess < num) 
        {
          Console.WriteLine("Ditt tal är för litet. Gissa på ett större tal");

          if (Math.Abs(num - guess) <= 3)
          {
            Console.WriteLine("Du är dock nära och det bränns");
          }
        }


        // Kontrollera om gissa är större än tal och dock nära
        else if (guess > num)
        {
          Console.WriteLine("Ditt tal är för stort. Gissa på ett mindre tal");

          if (Math.Abs(num - guess) <= 3)
          {
            Console.WriteLine("Du är dock nära");
          }
        }

        else 
        {
          Console.WriteLine($"Gratis - du gissade rätt, och du behövde {guessCount} gissningar på dig!");

          correctGuess = true;

          // Uppdatera bästa resultat om man gissat rätt
          if (correctGuess && guessCount < bestRecord) 
          {  
            bestRecord = guessCount;
          }
          
        }
        
        // Kontroll: Max 10 gissningar
        if (guessCount == 10 && !correctGuess)
        {
          Console.WriteLine("\nDu har nått max 10 gissningar. Rätt svar var: " + num);
          
          break;
        }
      
      } while (!correctGuess);



      // Fråga om spelaren vill spela igen
      Console.WriteLine("\nVill du spela en ny omgång? (y/n):");

      string response = Console.ReadLine().ToLower();

      if (response != "y")
      {
        playAgain = false;
        
        if (bestRecord == int.MaxValue)
        {
          Console.WriteLine("\nTack för att du spelade! Du lyckades tyvärr inte gissa rätt denna gång.");
        }
        else 
        {
          Console.WriteLine($"\nTack för att du spelade! Ditt bästa resultat var {bestRecord} gissningar.");
        }     
      }
      
    }  
  }
}
