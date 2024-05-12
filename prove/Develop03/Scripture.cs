using System.Text;

public class Scripture
{
    private List<Word> _words= new List <Word> ();
    private string _scripture;
    private string _originalScripture;


    public void SetScripture(string text)
    {
        _scripture = text;
        _originalScripture = text;
    }

    public void HideRandomWord()
    {
        Random randomIndex = new Random();
        int index;

        do
        {
            index = randomIndex.Next(_words.Count);

        } while (_words[index].IsHidden());

        _words[index].Hide();

        
    }

    public void AddWords ()
    { 
        string[] words = _scripture.Split(' ');

        List<string> wordsList = new List<string>(words);

        foreach(string word in words)
        {
            Word newWord = new Word ();
            newWord.SetWord(word);
            _words.Add(newWord);
        }
    }

    public string DisplayText ()
    {
        StringBuilder displayText = new StringBuilder ();

        foreach(Word word in _words)
        {
            displayText.Append(word.GetWord()).Append(' ');
        }

        _scripture = displayText.ToString().Trim();

        return _scripture;
    }

    public bool IsCompletyHidden () 
    {
        foreach(Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void ResetScripture ()
    {
        foreach (Word word in _words)
        {
            word.Show();
        }
    }

    
}