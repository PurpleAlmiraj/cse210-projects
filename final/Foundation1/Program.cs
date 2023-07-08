using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video();
        video.Author = "GameMaster123";
        video.Title = "Epic Gaming Moments";
        video.Length = 605;
        video.PrintDetails();

        Comment comment = new Comment();
        comment.comentor1 = "PlayerOne";
        comment.comment1 = "Wow, that headshot was insane!";
        comment.comentor2 = "GamerGirl88";
        comment.comment2 = "This game looks so much fun! I can't wait to try it.";
        comment.comentor3 = "ProGamer99";
        comment.comment3 = "Awesome gameplay! You make it look so easy.";
        comment.PrintComment();

        Video video2 = new Video();
        video2.Author = "StarLogger";
        video2.Title = "The Mysteries of the Stars";
        video2.Length = 1375;
        video2.PrintDetails();

        Comment comment2 = new Comment();
        comment2.comentor1 = "CosmicExplorer";
        comment2.comment1 = "I find astrology so fascinating! It's amazing how celestial bodies can influence our lives.";
        comment2.comentor2 = "StarGazer77";
        comment2.comment2 = "This video provided valuable insights into my zodiac sign. Thanks for sharing";
        comment2.comentor3 = "LunaMystic";
        comment2.comment3 = "Astrology has helped me understand myself better and navigate life's challenges. Keep up the great work!";
        comment2.PrintComment();

        Video video3 = new Video();
        video3.Author = "PetLover99";
        video3.Title = "Adorable Dogs: The Cuteness Overload";
        video3.Length = 340;
        video3.PrintDetails();

        Comment comment3 = new Comment();
        comment3.comentor1 = "Alex123";
        comment3.comment1 = "Such a heartwarming video! Dogs never fail to make me smile.";
        comment3.comentor2 = "EmilySmith22";
        comment3.comment2 = "I can't handle the cuteness! This video made my day.";
        comment3.comentor3 = "JamesJohnson47";
        comment3.comment3 = "Dogs are truly the best companions. Thanks for sharing this delightful video!";
        comment3.PrintComment();

    }
}
