using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("GameMaster123", "Epic Gaming Moments", 605);
        video.AddComment("PlayerOne", "Wow, that headshot was insane!");
        video.AddComment("GamerGirl88", "This game looks so much fun! I can't wait to try it.");
        video.AddComment("ProGamer99", "Awesome gameplay! You make it look so easy.");
        video.PrintDetails();
        video.PrintComments();

        Video video2 = new Video("StarLogger", "The Mysteries of the Stars", 1375);
        video2.AddComment("CosmicExplorer", "I find astrology so fascinating! It's amazing how celestial bodies can influence our lives.");
        video2.AddComment("StarGazer77", "This video provided valuable insights into my zodiac sign. Thanks for sharing");
        video2.AddComment("LunaMystic", "Astrology has helped me understand myself better and navigate life's challenges. Keep up the great work!");
        video2.PrintDetails();
        video2.PrintComments();

        Video video3 = new Video("PetLover99", "Adorable Dogs: The Cuteness Overload", 340);
        video3.AddComment("Alex123", "Such a heartwarming video! Dogs never fail to make me smile.");
        video3.AddComment("EmilySmith22", "I can't handle the cuteness! This video made my day.");
        video3.AddComment("JamesJohnson47", "Dogs are truly the best companions. Thanks for sharing this delightful video!");
        video3.PrintDetails();
        video3.PrintComments();
    }
}
