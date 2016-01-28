using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Skelly
{
    private string skelly;
    private string skelly1 = "      _______\n     |       |\n             |\n             |\n             |\n             |\n             |\n         ____|____\n";
    private string skelly2 = "      _______\n     |       |\n     O       |\n             |\n             |\n             |\n             |\n         ____|____\n";
    private string skelly3 = "      _______\n     |       |\n     O       |\n     |       |\n             |\n             |\n             |\n         ____|____\n";
    private string skelly4 = "      _______\n     |       |\n     O       |\n    _|       |\n             |\n             |\n             |\n         ____|____\n";
    private string skelly5 = "      _______\n     |       |\n     O       |\n    _|_      |\n             |\n             |\n             |\n         ____|____\n";
    private string skelly6 = "      _______\n     |       |\n     O       |\n    _|_      |\n     |       |\n             |\n             |\n         ____|____\n";
    private string skelly7 = "      _______\n     |       |\n     O       |\n    _|_      |\n     |       |\n    /        |\n             |\n         ____|____\n";
    private string skelly8 = "      _______\n     |       |\n     O       |\n    _|_      |\n     |       |\n    / \\      |\n             |\n         ____|____\n";
    private string[] list = new string[8];

	public Skelly()
    {
        skelly = skelly1;
        list[0] = skelly1; list[1] = skelly2; list[2] = skelly3; list[3] = skelly4; 
        list[4] = skelly5; list[5] = skelly6; list[6] = skelly7; list[7] = skelly8;
	}

    public string getSkelly()
    {
        return skelly;
    }

    public void sorrySkelly(int score)
    {
        for (int i = 0; i <= score; i++)
        {
            skelly = list[i];
        }
    }
}
