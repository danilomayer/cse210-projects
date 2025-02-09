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
    // Attributes
    private string _reference; // The reference of the scripture.
    private string _words; // The text of the scripture.

    // Class Behaviors
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
    // Attributes
    private string _text; // The text of the word.
    private bool _hidden; // Whether the word is hidden.

    // Class Behaviors
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
    // Attributes
    private string _book; // The name of the book.
    private int _chapter; // The chapter number.
    private int _verse; // The verse number.
    private int _endVerse; // The ending verse number.

    // Constructor for single verse reference
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    // Constructor for range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Getters and Setters for Book
    public string GetBook()
    {
        return _book;
    }

    public int SetBook(string book)
    {
        _book = book;
    }

    // Getters and Setters for Chapter
    public int GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    // Getters and Setters for Verse
    public int GetVerse()
    {
        return _verse;
    }

    public void SerVerse(int verse)
    {
        _verse = verse;
    }

    // Getters and Setters for EndVerse
    public int GetEndVerse()
    {
        return _endVerse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    // Class Behavior to display text
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}