using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public bool HideRandomWords(int count = 1)
    {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (!visibleWords.Any())
        {
            return false;
        }

        Random random = new Random();
        var wordsToHide = visibleWords.OrderBy(_ => random.Next()).Take(Math.Min(count, visibleWords.Count));

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }

        return true;
    }

    public override string ToString()
    {
        string wordsStr = string.Join(" ", _words.Select(word => word.ToString()));
        return $"{_reference}\n{wordsStr}";
    }

    public string GetDisplayText()
    {
        return ToString();
    }
}