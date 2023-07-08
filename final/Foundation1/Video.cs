using System;
using System.Collections.Generic;

public class Video
{
    public string Author = " ";
    public string Title = " ";
    public int Length = 0;

    public void PrintDetails()
    {
        Console.WriteLine();
        Console.WriteLine($"'{Title}'({Length} seconds) by {Author}" );
        Console.WriteLine();
    }

}