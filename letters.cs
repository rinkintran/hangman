//letters keeps track of guessed letters
using System;
using System.Text;

public class letters
{
    private StringBuilder lettersUsed = new StringBuilder("");
    private int incorrectGuesses;

    //initializes incorrect guesses to 0
	public letters()
	{
        incorrectGuesses = 0;
	}

    //prints incorrect letters guessed into the console
    public void print()
    {
        Console.Write(lettersUsed);
    }

    //checks the string to see if it already contains the letter we input
    public bool contains(char input)
    {
        string input1 = input.ToString();
        return lettersUsed.ToString().Contains(input1);
    }

    //updates string if user guesses an incorrect letter, returns error if we already guessed the letter
    public void update(bool correctGuess, char input) 
    {
        if (!correctGuess)
        {
            incorrectGuesses++;
            if (!this.contains(input))
            {
                lettersUsed.Append(input);
            }
            else
            {
                Console.Write("You've already guessed this letter! Please enter a different letter");
            }
        }
    }

    //returns incorrect letters guessed as a string
    public string getLettersUsed()
    {
        return lettersUsed.ToString();
    }

    //returns amount of incorrect guesses user has performed
    public int getIncorrectGuesses()
    {
        return incorrectGuesses;
    }
}
