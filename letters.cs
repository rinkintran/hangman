//letters keeps track of guessed letters
using System;
using System.Text;

public class letters
{
    private StringBuilder lettersUsed = new StringBuilder();
    private int incorrectGuesses;

	public letters()
	{
        lettersUsed = "";
        incorrectGuesses = 0;
	}

    //prints incorrect letters guessed into the console
    public void print()
    {
        Console.Write(lettersUsed);
    }

    public bool contains(char input)
    {
        if (this.get().Contains(input))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //updates string if user guesses an incorrect letter
    public void update(bool correctGuess, char input) 
    {
        if (!correctGuess)
        {
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
    public string get()
    {
        return lettersUsed.ToString();
    }
}
