using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creates a list to store videos
        List<Video> videos = new List<Video>();

        // Creates videos and adds them to the list
        Video video1 = new Video("Video 1", "Author 1", 60);
        video1.AddComment("Joe", "Great video!");
        video1.AddComment("Sarah", "Really helpful.");
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 120);
        video2.AddComment("Mike", "Really cool.");
        video2.AddComment("Laila", "Awesome video =]");
        video2.AddComment("Ana", "Looks amazing.");
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 180);
        video3.AddComment("Rafael", "Well explained.");
        video3.AddComment("Henrique", "Keep up the good work!");
        video3.AddComment("Romeo", "Well played.");
        video3.AddComment("Roberto", "Sounds great, my friend.");
        videos.Add(video3);

        // Iterates through the list of videos to display information
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length (seconds): " + video._length);
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (var comment in video._comments)
            {
                Console.WriteLine(" - " + comment._commenterName + ": " + comment._text);
            }
            Console.WriteLine();
        }
    }
}