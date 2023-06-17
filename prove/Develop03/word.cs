class Word
{
    private string _word;
    private bool _hidden = false;

    private string _sentence = "nice day";

    public Word(string letters)
    {
        _word = letters;
    }

    public void Hide_word()
    {
        _hidden = true;
    }

    public string Get_word()
    {
         if (_hidden == false)
        {
            return _word;
        }
        else
        {
            return "_________";
        }

    }

    public bool get_hidden()
    {
        return _hidden;
    }

    public string word_return()
    {
        return _word;
    }
}