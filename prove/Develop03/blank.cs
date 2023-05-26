public class Blank
{
    public string ProcessScripture(string reference, string scripture, int number)
    {
        // Split the scripture into individual words
        string[] words = scripture.Split(' ');

        // Get the indices of words that are not already blanked out
        List<int> indicesToBlank = new List<int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (!IsWordBlanked(words[i]))
                indicesToBlank.Add(i);
        }

        // Randomly select three indices from the available indices
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

        // Join the words back into a string
        string modifiedScripture = string.Join(" ", words);

        // Generate the full scripture with reference
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
