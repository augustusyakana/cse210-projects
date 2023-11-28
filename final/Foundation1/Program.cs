using System;

class Program
{
    static void Main(string[] args)
    {
        string title1 = "First Video";
        string author1 = "Augustus";
        int length1 = 60;
        Video video1 = new Video(title1, author1, length1);
        string commenter1 = "Tieg";
        string comment1 = "This is a good video!";
        string commenter2 = "Prince";
        string comment2 = "Nice!";
        string commenter3 = "Chris";
        string comment3 = "Wow!";
        video1.AddComment(commenter1, comment1);
        video1.AddComment(commenter2, comment2);
        video1.AddComment(commenter3, comment3);
        Console.WriteLine(video1.DisplayVideoDetails());
        video1.DisplayComments();

        string title2 = "Second Video";
        string author2 = "Yuki";
        int length2 = 90;
        Video video2 = new Video(title2, author2, length2);
        string commenter4 = "Ryan";
        string comment4 = "Insightful!";
        string commenter5 = "Kimo";
        string comment5 = "I gotta share this with my friends!";
        string commenter6 = "Aurora";
        string comment6 = "Thank you for posting this nice video!";
        video2.AddComment(commenter4, comment4);
        video2.AddComment(commenter5, comment5);
        video2.AddComment(commenter6, comment6);
        Console.WriteLine(video2.DisplayVideoDetails());
        video2.DisplayComments();

        string title3 = "Third Video";
        string author3 = "Yakana";
        int length3 = 120;
        Video video3 = new Video(title3, author3, length3);
        string commenter7 = "Legend";
        string comment7 = "Nice graphics!";
        string commenter8 = "Tierra";
        string comment8 = "This video is topnotch!";
        string commenter9 = "Maria";
        string comment9 = "Love it!";
        string commenter10 = "Kendall";
        string comment10 = "Wow! Good job!";
        video3.AddComment(commenter7, comment7);
        video3.AddComment(commenter8, comment8);
        video3.AddComment(commenter9, comment9);
        video3.AddComment(commenter10, comment10);
        Console.WriteLine(video3.DisplayVideoDetails());
        video3.DisplayComments();
    }
}