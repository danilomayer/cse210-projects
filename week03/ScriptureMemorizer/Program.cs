using System;
// People often try to memorize poems or passages of scripture. One of the challenges they encounter is that they want to hide the scripture while they are practicing, but they may not be able to recite the whole scripture from memory just yet.
// Create a program that will allow the user to input a scripture passage. The program should then display the scripture one word at a time. The user should be able to press a key to reveal the next word in the scripture. The user should be able to press a key to hide the word and display the previous word.
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Ezekiel", 25, 17);
        Scripture scripture = new Scripture(reference, "The path of the righteous man is beset on all sides by the Inequities of the selfish and the tyranny of evil men Blessed is he who, in the name of charity and good will shepherds the weak through the valley of darkness for he is truly his brother's keeper and the finder of lost children And I will strike down upon thee with great vengeance and furious Anger those who attempt to poison and destroy my brothers And you will know My name is the Lord when I lay my vengeance upon thee");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.AllWordHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture);
                Console.WriteLine("\nAll words are hidden. Program will now exit.");
                break;
            }
        }
    }
}

// Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
class Scripture
{
    // Attributes
    private Reference _reference; // The reference of the scripture.
    private List<Word> _words; // The text of the scripture.

    // Class Behaviors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void HideRandomWords(int number)
    {
        Random random = new Random();
        for (int i = 0; i < number; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        string scriptureText = string.Join(" ", _words);
        return $"{_reference.GetDisplayText()}\n{scriptureText}";
    }
}

// Keeps track of a single word and whether it is shown or hidden.
class Word
{
    // Attributes
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        if (IsHidden)
        {
            return new string('_', Text.Length);
        }
        else
        {
            return Text;
        }
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