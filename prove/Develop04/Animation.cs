class Animation
{
    private string[] spin = new string[]
    {
        "/",
        "-",
        "\\",
        "|",
    };

    public void Animationspin(int count, int duration)
    {
        for (int i = 0; i < count; i++)
        {
            foreach (string character in spin)
            {
                Console.Write(character);
                Pause(duration);
                Console.Write("\b \b");
            }
        }

        Console.WriteLine();
    }

    private void Pause(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }
}