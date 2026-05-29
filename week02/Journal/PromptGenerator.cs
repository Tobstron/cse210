using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What are you grateful for today?",
        "What is something new you learned today?",
        "What is a challenge you faced today and how did you overcome it?",
        "What is a goal you have for tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        
        return _prompts[index];
    }
}