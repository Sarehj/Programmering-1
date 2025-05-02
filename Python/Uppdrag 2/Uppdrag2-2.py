import random

print("Gissa talet")
print("Du ska nu gissa ett tal mellan 1 och 100, så varsågod..")

tal = random.randint(1, 100)
gissa = int(input("Skriv in ett tal\n"))

if gissa < 1 or gissa > 100:
  print("Du måste skriva in ett tal mellan 1 och 100!")
  exit() #Avslutar programmet (to not run the rest of the code)



if gissa < tal:
  print("Ditt tal är för litet. Gissa på ett större tal")
  if abs(gissa - tal) <= 3:
    print("Du är dock nära och det bränns")
  
elif gissa > tal:
  print("Ditt tal är för stort. Gissa på ett mindre tal")
  if abs(gissa - tal) <= 3:
    print("Du är dock nära och det bränns")

else:
  print("Du gissade rätt!")


print("\nProgrammet är avslut")