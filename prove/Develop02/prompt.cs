using System;


class Prompt
{
    public string promptGenerator()
    {
        List<string> suggestions = new();
        string prompt1 = "What was the best part of your day?";
        string prompt2 = "What did you look forward to today?";
        string prompt3 = "How did you find joy today?";
        string prompt4 = "Tell me your darkest secret.";
        string prompt5 = "What is the air speed velocity of an unladen swallow?";

        
        suggestions.Add(prompt1);
        suggestions.Add(prompt2);
        suggestions.Add(prompt3);
        suggestions.Add(prompt4);
        suggestions.Add(prompt5);

        Random randomPrompt = new();
        int index = randomPrompt.Next(suggestions.Count);
        return suggestions[index];
    }
    
}