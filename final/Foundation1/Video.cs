using System;
using System.Collections.Generic;

class Video
{
    private string _author;
    private string _title;
    private int _length;
    private List<Comment> comments;

    public Video(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
        comments = new List<Comment>();
    }

    public void AddComment(string commentor, string comment)
    {
        Comment newComment = new Comment(commentor, comment);
        comments.Add(newComment);
    }

    public void PrintDetails()
    {
        Console.WriteLine();
        
        Console.WriteLine($"Video: '{_title}' ({_length} seconds) by {_author}");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine();
    }

    public void PrintComments()
    {
        foreach (Comment comment in comments)
        {
            comment.PrintComment();
            
        }
    }
}
