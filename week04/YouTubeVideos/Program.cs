using System;

class Program
{
    static void Main(string[] args)
    {

    }
}

// Track the title, author, and length (in seconds) of the video. Store a list of comments, and return the number of comments.
class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Length: " + lengthInSeconds + " seconds");
        Console.WriteLine("Number of Comments: " + GetCommentCount());
        Console.WriteLine("Comments:");

        foreach (var comment in comments)
        {
            Console.WriteLine(" - " + comment.GetCommentDetails());
        }

        Console.WriteLine();
    }
}

// Tracking the name of the person who made the comment and the text of the comment.
class Comment
{
    private string commenterName;
    private string text;

    public Comment(string commenterName, string text)
    {
        this.commenterName = commenterName;
        this.text = text;
    }

    public string GetCommentDetails()
    {
        return commenterName + ": " + text;
    }
}

