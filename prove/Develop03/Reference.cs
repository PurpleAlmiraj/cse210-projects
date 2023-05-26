using System;
using System.Collections.Generic;

public class Reference
{
    private List<string> References = new List<string>
    {
        "John 3:16",
        "Proverbs 3:5-6",
    };

    private Random random = new Random();

    public string GetRandomItem()
    {
        int randomIndex = random.Next(0, References.Count);
        string randomItem = References[randomIndex];
        return randomItem;
    }

    public List<string> GetScripture(string reference)
    {
        List<string> scriptureList = new List<string>();

        if (reference == "John 3:16")
        {
            scriptureList.Add("For");
            scriptureList.Add("God");
            scriptureList.Add("so");
            scriptureList.Add("loved");
            scriptureList.Add("the");
            scriptureList.Add("world,");
            scriptureList.Add("that");
            scriptureList.Add("he");
            scriptureList.Add("gave");
            scriptureList.Add("his");
            scriptureList.Add("one");
            scriptureList.Add("and");
            scriptureList.Add("only");
            scriptureList.Add("Son,");
            scriptureList.Add("that");
            scriptureList.Add("whoever");
            scriptureList.Add("believes");
            scriptureList.Add("in");
            scriptureList.Add("him");
            scriptureList.Add("shall");
            scriptureList.Add("not");
            scriptureList.Add("perish");
            scriptureList.Add("but");
            scriptureList.Add("have");
            scriptureList.Add("eternal");
            scriptureList.Add("life.");
        }
        else if (reference == "Proverbs 3:5-6")
        {
            scriptureList.Add("Trust");
            scriptureList.Add("in");
            scriptureList.Add("the");
            scriptureList.Add("Lord");
            scriptureList.Add("with");
            scriptureList.Add("all");
            scriptureList.Add("your");
            scriptureList.Add("heart");
            scriptureList.Add("and");
            scriptureList.Add("lean");
            scriptureList.Add("not");
            scriptureList.Add("on");
            scriptureList.Add("your");
            scriptureList.Add("own");
            scriptureList.Add("understanding;");
            scriptureList.Add("in");
            scriptureList.Add("all");
            scriptureList.Add("your");
            scriptureList.Add("ways");
            scriptureList.Add("submit");
            scriptureList.Add("to");
            scriptureList.Add("him,");
            scriptureList.Add("and");
            scriptureList.Add("he");
            scriptureList.Add("will");
            scriptureList.Add("make");
            scriptureList.Add("your");
            scriptureList.Add("paths");
            scriptureList.Add("straight.");
        }

        return scriptureList;
    }
}



