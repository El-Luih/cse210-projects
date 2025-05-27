using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";

        displayText += $"{_reference.GetDisplayText()} ";
        foreach (Word word in _words)
        {
            displayText += $"{word.GetDisplayText()} ";
        }

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
    public void HideRandomWords(int numberOfWords)
    {
        Random indexesGenerator = new Random();
        int hiddenWordIndex;
        int successfulAttempts = 0;
        while (successfulAttempts < numberOfWords && IsCompletelyHidden() == false)
        {
            hiddenWordIndex = indexesGenerator.Next(0, _words.Count);
            if (_words[hiddenWordIndex].IsHidden() == false)
            {
                _words[hiddenWordIndex].Hide();
                successfulAttempts += 1;
            }
        }
    }
}