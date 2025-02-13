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
    private int length;
    private List<Comment> comments;

    AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    GetCommentCount()
    {
        return comments.Count;
    }

    DisplayInfo()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Comment Count: " + GetCommentCount());
    }
}

// Tracking the name of the person who made the comment and the text of the comment.
class Comment
{

}

