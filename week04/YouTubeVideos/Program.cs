using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new video
        Video video1 = new Video("C# Tutorial", "Bob", 60);
        Video video2 = new Video("Python Tutorial", "Alice", 120);
        Video video3 = new Video("Java Tutorial", "Charlie", 180);

        // Add comments video 1
        video1.AddComment(new Comment("John", "Great video!"));
        video1.AddComment(new Comment("Jane", "I learned a lot from this video!"));
        video1.AddComment(new Comment("Jim", "This video is very helpful!"));

        // Add comments video 2
        video2.AddComment(new Comment("Mike", "Fantastic video!"));
        video2.AddComment(new Comment("Molly", "I love this video!"));
        video2.AddComment(new Comment("Max", "This video is amazing!"));
        video2.AddComment(new Comment("Mia", "I learned a lot from this video!"));

        // Add comments video 3
        video3.AddComment(new Comment("Nathan", "Marvelous video!"));
        video3.AddComment(new Comment("Nina", "I learned a lot from this video!"));

        // Store videos in a List
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}

// Track the title, author, and length (in seconds) of the video. Store a list of comments, and return the number of comments.
class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Length: " + _lengthInSeconds + " seconds");
        Console.WriteLine("Number of Comments: " + GetCommentCount());
        Console.WriteLine("Comments:");

        foreach (var comment in _comments)
        {
            Console.WriteLine(" - " + comment.GetCommentDetails());
        }

        Console.WriteLine();
    }
}

// Tracking the name of the person who made the comment and the text of the comment.
class Comment
{
    private string _commenterName;
    private string _text;

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public string GetCommentDetails()
    {
        return _commenterName + ": " + _text;
    }
}

