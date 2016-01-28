using System;
using System.IO;

/// <summary>
/// Dictionary class for Hangman.exe, can lookup word based on difficulty, and scan to see if an input letter is correct
/// </summary>
public class Dictionary
{
    private int num = 0;
    private Random rnd;
    private string word;
    private FileStream file;
    private StreamReader sr;
    private string[] dict = new string[109557];

    //Constructor
	public Dictionary()
	{
        file = new FileStream(@"C:\Users\BenerE01\Documents\GitHub\hangman\Dictionary.txt", FileMode.Open, FileAccess.Read);
        sr = new StreamReader(file);

        for (int b = 0; b < 109557; b++)
        {
            dict[b] = sr.ReadLine();
        }

        word = sr.ReadLine();
	}

    //Find new word from dictionary.txt
    //difficulty 1 = 4 letters, 2 = 5, 3 = 6, 4 = 7, 5 = 8
    public void newWord(int difficulty)
    {
        rnd = new Random();

        while (word.Length != (difficulty + 3))
        {
            num = rnd.Next(0, 109557);
            word = dict[num];
            //Console.WriteLine(num);
            //Console.WriteLine(word);
        }
    }

    //Get method for returning interval variable word
    public string getWord()
    {
        return word;
    }
}
