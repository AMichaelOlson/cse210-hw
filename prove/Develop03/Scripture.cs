using System;
using System.Collections.Generic;

public class Scripture
{
    public List<Words> ListWords { get; } = new List<Words>();

    public void AddToList(Words word)
    {
        ListWords.Add(word);
    }

    public void Display()
    {
        Reference reference = new Reference();
        Console.WriteLine(reference.GetReference());

        bool firstWord = true;

        foreach (Words word in ListWords)
        {
            if (word.Show)
            {
                if (!firstWord)
                {
                    Console.Write(" ");
                }
                Console.Write($"{word.Word}");
                firstWord = false;
            }
            else
            {
                string underscores = "";
                string wordString = word.Word;

                foreach (char letter in wordString)
                {
                    if (letter == ' ')
                    {
                        underscores += " ";
                    }
                    else
                    {
                        underscores += (letter == ',' || letter == ';' || letter == '.') ? letter.ToString() : "_";
                    }
                }

                Console.Write($"{underscores} ");
            }
        }
    }

    public void UnderscoreRandomWord()
    {
        Random rand = new Random();

        while (true)
        {
            int randomIndex = rand.Next(0, ListWords.Count);

            if (ListWords.TrueForAll(word => !word.Show))
            {
                break;
            }

            if (ListWords[randomIndex].Show)
            {
                ListWords[randomIndex].SetShowFalse();
                break;
            }
        }
    }
}