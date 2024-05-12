public class Word 
{
    private string _word;
    private string _originalWord;
    private bool _isHidden = false;


    public void SetWord(string word)
    {
        _word = word;
        _originalWord = word;
    }

    public string GetWord()
    {
        return _word;
    }

    public void Hide ()
    {
        string hiddenWord = new string('_', _word.Length);
        _word = hiddenWord;
        _isHidden = true;
    }

    public void Show ()
    {
        _word = _originalWord;
        _isHidden = false;
    }

    public bool IsHidden ()
    {
        if (_isHidden == true)
        {
            return true;
        }

        else 
        {
            return false;
        }
    }

}