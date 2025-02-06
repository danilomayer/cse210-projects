using System;
// People often try to memorize poems or passages of scripture. One of the challenges they encounter is that they want to hide the scripture while they are practicing, but they may not be able to recite the whole scripture from memory just yet.
// Create a program that will allow the user to input a scripture passage. The program should then display the scripture one word at a time. The user should be able to press a key to reveal the next word in the scripture. The user should be able to press a key to hide the word and display the previous word.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
    }
}

// Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
class Scripture
{
    public void HideRandomWords(int number)
    {
        return;
    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}

// Keeps track of a single word and whether it is shown or hidden.
class Word
{
    public void Hide()
    {
        return;
    }

    public void Show()
    {
        return;
    }

    public bool IsHidden()
    {
        return false;
    }

    public string GetDisplayText()
    {
        return "";
    }
}

// Keeps track of the book, chapter, and verse information.
class Reference
{
    public string GetDisplayText()
    {
        return "";
    }
}