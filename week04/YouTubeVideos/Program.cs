using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Learning C# Basics";
        video1._author = "Code Academy";
        video1._length = 600;

        video1._comments.Add(new Comment("John", "Great tutorial!"));
        video1._comments.Add(new Comment("Sarah", "Very helpful."));
        video1._comments.Add(new Comment("Mike", "Thanks for explaining clearly."));

        Video video2 = new Video();
        video2._title = "Space Exploration";
        video2._author = "Science Hub";
        video2._length = 850;

        video2._comments.Add(new Comment("Alex", "Amazing video!"));
        video2._comments.Add(new Comment("Emma", "I learned a lot."));
        video2._comments.Add(new Comment("James", "Awesome content."));

        Video video3 = new Video();
        video3._title = "Top 10 Football Goals";
        video3._author = "Sports Central";
        video3._length = 420;

        video3._comments.Add(new Comment("Chris", "Best goals ever."));
        video3._comments.Add(new Comment("David", "Fantastic compilation."));
        video3._comments.Add(new Comment("Ryan", "Loved it!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}
