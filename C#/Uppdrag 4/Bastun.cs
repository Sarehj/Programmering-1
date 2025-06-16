using System;

class Bastun
{
    public static void Main(string[] args)
    {
        decimal celsius = 0;
        int fahrenheit = 0;
        
        
        while(true)
        {
            try 
            {

                while (celsius < 82 || celsius > 87)
                {
                    Console.WriteLine("skriv in bastutemperatur i fahrenheit");
                    fahrenheit = Convert.ToInt32(Console.ReadLine());

                    // Convert Fahrenheit to Celsius
                    // Use overloaded method if input is 0
                    if (fahrenheit == 0 )
                    {
                        celsius = fahr_to_cel();
                    }
                    else 
                    {
                        celsius = fahr_to_cel(fahrenheit);
                    }

                    // Temperature feedback
                    if (celsius < 82)
                    {
                        Console.WriteLine("Det är för kallt");
                    }
                    else if (celsius > 87)
                    {
                        Console.WriteLine("Det är för varmt");
                    }
                }

                // When the temperature is within the acceptable range
                Console.WriteLine("Temperatren är lagom");
                break;
                
            }
            catch
            {
                Console.WriteLine("Fel inträffade! Du måste skriva in ett tal.");
            }
        }
    }

    
    
    // Method to convert Fahrenheit to Celsius
    public static decimal fahr_to_cel(int fahrenheit)
    {
        return (fahrenheit - 32) * 5m / 9m;
    }

    
    //Overloaded method, returns Celsius after generating random Fahrenheit
     public static decimal fahr_to_cel()
    {
        int fahr = new Random().Next(0, 250);
        return fahr_to_cel(fahr);
    }
}