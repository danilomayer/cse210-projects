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

