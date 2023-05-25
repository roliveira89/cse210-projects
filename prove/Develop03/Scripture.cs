class Scripture
{
    private Reference reference;
    private string text;
    private Word[] words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.text = text;

        string[] wordArray = text.Split(' ');
        words = new Word[wordArray.Length];

        for (int i = 0; i < wordArray.Length; i++)
        {
            words[i] = new Word(wordArray[i]);
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(reference.GetReference());
        foreach (Word word in words)
        {
            Console.Write(word.GetHiddenText() + " ");
        }
        Console.WriteLine();
    }

public void HideRandomWords(Random random, int count)
{
    int wordsToHide = Math.Min(count, words.Length);
    List<int> unhiddenIndices = new List<int>();

    for (int i = 0; i < words.Length; i++)
    {
        if (!words[i].IsHidden)
        {
            unhiddenIndices.Add(i);
        }
    }

    if (unhiddenIndices.Count < wordsToHide)
    {
        wordsToHide = unhiddenIndices.Count;
    }

    for (int i = 0; i < wordsToHide; i++)
    {
        int randomIndex = random.Next(unhiddenIndices.Count);
        int wordIndex = unhiddenIndices[randomIndex];
        words[wordIndex].Hide();
        unhiddenIndices.RemoveAt(randomIndex);
    }
}

    public bool AllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }
}