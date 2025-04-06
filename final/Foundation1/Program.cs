using System;
using System.Collections.Generic;

public class Comment
{
    public string Commenter { get; set; }
    public string Text { get; set; }

    public Comment(string commenter, string text)
    {
        Commenter = commenter;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Commenter}: {Text}";
    }
}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Length: {Length} seconds, Comments: {GetNumberOfComments()}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating video instances
        Video video1 = new Video("Python Tutorial", "Code Academy", 600);
        Video video2 = new Video("Cooking Pasta", "Chef John", 300);
        Video video3 = new Video("Guitar Lesson", "Music School", 450);
        Video video4 = new Video("Travel Vlog", "World Explorer", 1200);

        // Creating comments for video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Nice explanation!"));

        // Creating comments for video2
        video2.AddComment(new Comment("Dave", "Yummy!"));
        video2.AddComment(new Comment("Eve", "Can't wait to try this recipe!"));
        video2.AddComment(new Comment("Frank", "Looks delicious!"));

        // Creating comments for video3
        video3.AddComment(new Comment("Grace", "Awesome lesson!"));
        video3.AddComment(new Comment("Heidi", "I learned a lot!"));
        video3.AddComment(new Comment("Ivan", "Thanks for the tips!"));

        // Creating comments for video4
        video4.AddComment(new Comment("Judy", "Amazing places!"));
        video4.AddComment(new Comment("Kenny", "I want to go there!"));
        video4.AddComment(new Comment("Laura", "Beautiful scenery!"));

        // Putting videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Iterating through the list of videos and displaying information
        foreach (Video video in videos)
        {
            Console.WriteLine(video);
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"\t{comment}");
            }
            Console.WriteLine();
        }
    }
}