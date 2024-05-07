public class PromptGenerator
{
    List<string> _prompts = new List<string>{"What was the highlight of your day?",
    "Describe a moment that made you laugh today:",
    "What was the most challenging part of your day?:",
    "Who inspired you today and why?:",
    "What is something new you learned today?:",
    "Describe a kind gesture you witnessed or received:",
    "Reflect on a decision you made today and its outcome:",
    "What are you grateful for today?:",
    "Describe a moment of personal growth or realization:",
    "Who made you feel appreciated today and how?:",
    "What was the most beautiful sight you saw today?:",
    "Reflect on a moment of peace or tranquility you experienced:",
    "What is something you accomplished today?:",
    "Who supported you today and how did they do so?:"};

    Random randomIndex = new Random();

    public string GetRandomPrompt()
    {
        string randomPrompt = _prompts[randomIndex.Next(_prompts.Count)];

        return randomPrompt;
    }
}