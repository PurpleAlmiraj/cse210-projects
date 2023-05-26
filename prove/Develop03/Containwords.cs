public class ContainWords
{
    public static bool ContainsWordsToBlank(string scripture)
    {
        string[] words = scripture.Split(' ');
        foreach (string word in words)
        {
            if (!IsWordBlanked(word))
                return true;
        }
        return false;
    }

    private static bool IsWordBlanked(string word)
    {
        foreach (char c in word)
        {
            if (c != '_')
                return false;
        }
        return true;
    }
}
