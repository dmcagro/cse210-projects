
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video(
            "Learn Fashion Design Basics",
            "DMC Fashion Academy",
            600);

        video1.AddComment(new Comment("Ade", "Very informative video!"));
        video1.AddComment(new Comment("Tola", "I learned a lot."));
        video1.AddComment(new Comment("Grace", "Great explanation."));
        video1.AddComment(new Comment("Kunle", "Please make more videos."));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video(
            "How to Sew a Skirt",
            "Fashion Mastery",
            900);

        video2.AddComment(new Comment("Sarah", "Amazing tutorial."));
        video2.AddComment(new Comment("James", "Easy to follow."));
        video2.AddComment(new Comment("Mary", "Thank you!"));
        video2.AddComment(new Comment("David", "Excellent content."));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video(
            "Beginner Tailoring Tips",
            "Creative Tailor",
            720);

        video3.AddComment(new Comment("Peter", "Helpful tips."));
        video3.AddComment(new Comment("Joy", "Loved this video."));
        video3.AddComment(new Comment("Esther", "Clear instructions."));
        video3.AddComment(new Comment("John", "Subscribed!"));

        videos.Add(video3);

        // Video 4
        Video video4 = new Video(
            "Starting a Fashion Business",
            "Entrepreneur Hub",
            1200);

        video4.AddComment(new Comment("Aisha", "Very motivating."));
        video4.AddComment(new Comment("Michael", "Great advice."));
        video4.AddComment(new Comment("Blessing", "Useful information."));
        video4.AddComment(new Comment("Daniel", "Thanks for sharing."));

        videos.Add(video4);

        // Display all videos and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine();

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"{comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}