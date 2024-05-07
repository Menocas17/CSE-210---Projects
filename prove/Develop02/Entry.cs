public class Entry
{
    public string _date = DateTime.Now.ToString("yy-MM-dd HH:mm");

    

    public string _propmText;
    public string _entryText;


    public void Display ()
    {
        Console.WriteLine(_date);
        PromptGenerator prompt = new PromptGenerator();
        _propmText = prompt.GetRandomPrompt();
        Console.WriteLine(_propmText);
        _entryText = Console.ReadLine();
    }

}


