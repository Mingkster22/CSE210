using System;

class Journal
{
   private List<Entry> List_entries = new List<Entry>();

   public List<string> promt_list = new List<string>();
    public void create_promts()
    {
        promt_list.Add("How was your day?");
        promt_list.Add("What did you eat today?");
        promt_list.Add("Did you talk to someone today, and if you did what did you talk about?");
        promt_list.Add("How would you describe your mood today?");
        promt_list.Add("Were there anything fun that happened to you so far?");
        promt_list.Add("How much time did you waste today, and why?");
        promt_list.Add("What good things did you do today?");
    }

    public void add_entry()
    {
        // Choose a random prompt.
        System.Random random_number_generator = new System.Random();
        int index = random_number_generator.Next(promt_list.Count);
        string random_prompt = promt_list[index];

        // Create an Entry object.
        Entry one_entry = new Entry();
        
        // Get the data for one entry.
        one_entry.get_entry_data(random_prompt);

        // Store one entry in the list of entries.
        List_entries.Add(one_entry);
    }

    public void load()
    {
        StreamReader loader = new StreamReader("saver_loader.txt");
        ReadFromFile();
    }

    public void save()
    {
        StreamWriter saver = new StreamWriter("saver_loader.txt");
        saver.WriteLine(List_entries);
        saver.Close();
    }

    public void Display()
    {
        // Print the list of prompts.
        foreach (string _promt in promt_list)
        {
            // _promt.Display();
            Console.WriteLine($"{_promt}");
        }
        // Print the list of entries.
        foreach (Entry entries in List_entries)
        {
            entries.Display();
        }
    }
}