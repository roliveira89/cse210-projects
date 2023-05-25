class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        isHidden = false;
    }

    public bool IsHidden
    {
        get { return isHidden; }
    }

    public void Hide()
    {
        isHidden = true;
    }

    public string GetHiddenText()
    {
        if (isHidden)
        {
            return new string('_', text.Length);
        }
        else
        {
            return text;
        }
    }
}