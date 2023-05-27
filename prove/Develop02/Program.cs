using System;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int menunumber = 1;
        while (menunumber == 1)
        {
            //memu
            Show display = new Show();
            int userChoice = display.Display();
            //Prompt
            PromptGenerator promptGenerator = new PromptGenerator();
            string prompt = promptGenerator.GetRandomPrompt();
            //Write
            if (userChoice == 1)
            {
                DateTime currentDate = DateTime.Now;
                string dateString = currentDate.ToString("yyyy-MM-dd");
                Console.WriteLine(prompt);
                string newentry = Console.ReadLine();
                DailyEntry entry1 = new DailyEntry();
                entry1._date = dateString;
                entry1._prompt = prompt;
                entry1._entry = newentry;
                journal.AddEntry(entry1);
                
            }
            // display
            if (userChoice == 2)
            {
               journal.DisplayEntries();
            }
            // load
            if (userChoice == 3)
            {
                string fileName = Console.ReadLine();
                string content = File.ReadAllText(fileName);

                // Display the contents
                Console.WriteLine(content);
            }
            // save
            if (userChoice == 4)
            {
                Console.WriteLine("Enter filename to save:");
                string filename = Console.ReadLine();
                journal.Save(filename);
            }
            // quit
            if (userChoice >= 5)
            {
                menunumber = 2;
            }



            
        
        }
    }
}