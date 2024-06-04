using System;
using System.Collections.Generic;

class Video {
    public string Title { get; set; }
    public string Author { get; set; }
    public int Seconds { get; set; }
    private List<Comment> Comments {get; }

    public Video(string title, string author, int length) {
        Title = title;
        Author = author;
        Seconds = length;
        Comments = new List<Comment>();
    }
    
    public void AddComment(string commenterName, string commentText) {
        Comments.Add(new Comment(commenterName, commentText));
    }

    public int GetCommentCount(){
        return Comments.Count;
    }

    public void DisplayInfo() {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Seconds} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine($"comments:");
        foreach (var comment in Comments) {
            Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
        }
        Console.WriteLine();
    }
}

class Comment {
    public string CommenterName { get; }
    public string CommentText { get; }

    public Comment(string commenterName, string commentText){
        CommenterName = commenterName;
        CommentText = commentText;
    }
}
