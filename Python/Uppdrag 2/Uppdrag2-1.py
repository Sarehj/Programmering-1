print("Välkomna till denna pensionssimulator")

#Hämta användaren namn
name = input("Vad heter du i förnamn? \n")
#Hämta användaren ålder
age = int(input("Hur gammal är du? \n"))

#Beräknar hur många år användaren har till pension
kvarTillPension = 65 - age

#kontrollera om användaren redan har gått i pension
if kvarTillPension > 0:
  print("Hej " + name + ". Du går i pension om " + str(kvarTillPension) +
        " år.")
else:
  print(f"Hej  {name}, du redan gått i pension")

input("Press Enter to continue ...")
