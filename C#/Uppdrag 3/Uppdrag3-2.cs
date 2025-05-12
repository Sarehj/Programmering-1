using System;
using System.Collections.Generic;
using System.Linq;

class Bingo
{
    public static void Main(string[] args)
    {

        Random random = new Random();
        int num = random.Next(1, 21);  // Generate a random number between 1 and 20

        
        // Part E

        List<int> userList = new List<int>();
        
        Console.WriteLine("Enter ten unique numbers between 1 and 20:");
        
        //Ask the user to enter 10 numbers
        while( userList.Count < 10)
        {
            
            Console.Write($"Number {userList.Count + 1}: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //Check if the user's number is between 1 and 20
            if (userInput < 1 || userInput > 20)
            {
                Console.WriteLine("Number should between 1 to 20! Try again!\n");
                continue;
            }
            
            
            //Check if the user's number is already in the list
            if (!userList.Contains(userInput))
            {
                userList.Add(userInput);
            }
            else 
            {
                Console.WriteLine("You have already entered this number.\n");
            }
            
            /* 
            // Another way to check if the user's number is already in the list 
            bool exist = false;
            foreach (int item in userList)
            {
               if (item == userInput)
                {
                    exist = true;
                    break;
                }
            }

            if (exist)
            {
                Console.WriteLine("You have already entered this number.");
            }
            else
            {
                userList.Add(userInput);
            } 
            */
        }

        
        //Check if the user's number is the same as the random number
        foreach (int i in userList)
        {
            if (i == num)
            {
                Console.WriteLine($"\nThe random number was: {num}   Bingo!\n\n\n");
            }
        }


        
        // part C 
        //Generate 10 random numbers and add them to a list
        List<int> randomList = new List<int>();
        while (randomList.Count < 10)
        {
            int randomListItem = random.Next(1, 21);
            if (!randomList.Contains(randomListItem))
            {
                randomList.Add(randomListItem);
            }
    
        }

        
        //Check if the user's number is the same as the random number
        int count = 0;

        foreach (int x in randomList) 
        {
            foreach (int y in userList)
            {
                if (x == y)
                {
                    Console.Write($"Bingo ({x})  ");
                    count ++;
                }  
            }    
        }

        Console.WriteLine($"\nDu fick {count} poäng\n\n\n");




        
        // Part A
        
        // Generate 5x5 unique random numbers between 1 and 25
        string[,] bingoBoard = new string[5,5];
        List<int> numbers = new List<int>();

        while (numbers.Count < 25)
        {
            int randomNum = random.Next(1, 26);
            if (!numbers.Contains(randomNum))
            {
                numbers.Add(randomNum);
            }
        }

        
        // Fill the bingo board with the random numbers
        int index = 0;
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                bingoBoard[row,col] = numbers[index].ToString();
                index++;
            }
        }
        
        
        // Ask the user to enter a number
        List<int> userNumbers = new List<int>();
        
        while(true)
        {

            // Print the bingo board
            Console.WriteLine("\n Bingo board:");
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write("  "+ bingoBoard[r,c] + "  ");
                }
                
                Console.WriteLine();
            }
            

            
            Console.WriteLine("Enter an unique numbers between 1 and 25:");
            int input = Convert.ToInt32(Console.ReadLine());

            
            //Check if the user's number is between 1 and 25
            if (input < 1 || input > 25)
            {
                Console.WriteLine("Number should between 1 to 25! Try again!");
                continue;
            }

            //Check if the user's number is already in the list
            if (!userNumbers.Contains(input))
            {
                userNumbers.Add(input);
            }
            else 
            {
                Console.WriteLine("You have already entered this number.");
            }


            
            // Mark the number on the board
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (bingoBoard[i, j] == input.ToString())
                    bingoBoard [i , j] = "X";
                }
            }

            

            // Check for Bingo 
            bool bingo= false;

            // Check rows and columns
            int rowBingo = 0;
            int colBingo = 0;
            for (int r = 0; r < 5; r++)
            {   
                for (int c = 0; c < 5; c++)
                {
                    if(bingoBoard[r,c] == "X")
                    {
                        rowBingo ++;
                    }
                    if(bingoBoard[c,r] == "X")
                    {
                        colBingo ++;
                    }
                }
                
                if (rowBingo == 5 || colBingo == 5)
                {
                    bingo = true;
                }
            }

            
            // Check diagonals
            int diagonal1 = 0;
            int diagonal2 = 0;
            int n = 4; // n is the index of the last column
            
            for (int i = 0; i < 5; i++)
            {
                if (bingoBoard[i, i] == "X")
                {
                    diagonal1++;
                }    
                if (bingoBoard[i, n--] == "X")
                {
                    diagonal2++;
                }  
            }
            if (diagonal1 == 5 || diagonal2 == 5)
            {
                bingo = true;
            }


            
            if (bingo) 
            {
                Console.WriteLine("Bingooo!");
                break;
            }
           
        }
        
        
    }

    
}




