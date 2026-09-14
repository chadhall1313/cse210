using System.Collections.Concurrent;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    Scripture(Reference reference, string text)
    {

        _reference = reference;

    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {

    }
    
    public bool IsCompletelyHidden()
    {
        
    }

}