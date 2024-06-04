using System;

class Program {
    static void Main(string[] args) {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to Programming", "John Doe", 300);
        video1.AddComment("Alice", "Great Video!");
        video1.AddComment("Bob", "Thanks for the explanation!");
        videos.Add(video1);

        Video video2 = new Video("Data Structures", "Jane Smith", 400);
        video2.AddComment("Charlie", "Very informative!");
        videos.Add(video2);

        foreach (var video in videos) {
            video.DisplayInfo();
        }
    }
}