public class Blank
{


    public string ProcessScripture(string reference, string scripture, int number)
    {
        // Split
        string[] words = scripture.Split(' ');
        // Blank out words not already blanked
        List<int> indicesToBlank = new List<int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (!IsWordBlanked(words[i]))
                indicesToBlank.Add(i);
        }
        // Random Select
        Random random = new Random();
        for (int i = 0; i < 3 && indicesToBlank.Count > 0; i++)
        {
            int randomIndex = random.Next(0, indicesToBlank.Count);
            int wordIndex = indicesToBlank[randomIndex];
            string word = words[wordIndex];
            string blankedWord = new string('_', word.Length);
            words[wordIndex] = blankedWord;
            indicesToBlank.RemoveAt(randomIndex);
        }

        string modifiedScripture = string.Join(" ", words);


        string fullScripture;
        fullScripture = modifiedScripture;
        return fullScripture;
    }

    private bool IsWordBlanked(string word)
    {
        foreach (char c in word)
        {
            if (c != '_')
                return false;
        }
        return true;
    }
}
