# Bastun
I uppgiften simulera inställning av temperatur i en bastu. Bastuns temperatur är lagom om den är mellan 82 och 87 grader celsius.  

Du ska också jobba med undantagshantering enligt studiematerialet. Det innebär att om man skriver in en bokstav eller felaktig siffra så kommer inte programmet att krascha. Det kan ska man lösa det med en loop som itererar så länge man inte skrivit in ett korrekt värde. 

### Pseudokod: 
```
Initiera celsius=0 
Initiera tal 
Gör medan celsius är lägre än 82 eller högre än 87 
     Mata in värde för Fahrenheit 
     Anropa fahr_to_cels(fahrenheit) till Celcius 
    Om Celsius är lägre än 82 
          Skriv ut "Det är för kallt" 
     Annars om Celsius är högre än 87 
           Skriv ut "Det är för varmt" 
Temperaturen är nu lagom 
```

### Vilkor:
* Användaren som är en amerikan skriver in bastutemperatur i fahrenheit. Temperaturen skrivs in som heltal. 
* Metod fahr_to_cel omvandlar Fahrenheit till Celsius och returnerar värdet som decimaltal. 
* Program kontrollerar om temperaturen är i intervallet 82-87 och svarar med ett meddelande :
  * ”Det är för varmt” 
  * ”Det är för kallt” 
  * ”Temperatren är lagom” 

* Koden upprepas tills temperaturen är lagom 


Om användaren skriver in 0(noll) istället för ett värde så den nya metoden användas : 

Observera att overlagringsmetoder fungerar inte på samma sätt i C# och python. 
* C#: Den nya metoden har samma namn men ej något argument. Metoden ska slumpa fram ett tal och därefter i sin tur returnera värdet till den ursprungliga metoden (med argument) för omvandling mellan Fahrenheit och Celsius. 
* Python: Den nya metoden ska slumpa fram ett tal och därefter i sin tur returnera värdet till den ursprungliga metoden (med argument) för omvandling mellan Fahrenheit och Celsius. 
