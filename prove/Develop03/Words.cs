using System;

public class Words
{
    public string Word { get; }
    public bool Show { get; private set; }

    public Words(string word)
    {
        Word = word;
        Show = true;
    }

    public override string ToString()
    {
        return Word;
    }

    public void SetShowFalse()
    {
        Show = false;
    }
}