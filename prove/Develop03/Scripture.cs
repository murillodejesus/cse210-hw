class Scripture
{
    private readonly Reference _reference;
    private readonly List<string> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<string>(text.Split(' '));
    }

    public string GetDisplayText()
    {
        return $"{_reference.ToString()}: {string.Join(" ", _words)}";
    }

    public void HideWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, _words.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index] = new string('_', _words[index].Length);
        }
    }
}