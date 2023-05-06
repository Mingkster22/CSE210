using System;

class Journal
{
   private List<Entry> List_entries = new List<Entry>();

   public List<string> promt_list = new List<string>();

   public List<string> promt_saved_list = new List<string>();

   public List<string> user_inputs = new List<string>();
        
    public void create_promts()
    {
        promt_saved_list.Add("How was your day?");
        promt_saved_list.Add("What did you eat today?");
        promt_saved_list.Add("Did you talk to someone today, and if you did what did you talk about?");
        promt_saved_list.Add("How would you describe your mood today?");
        promt_saved_list.Add("Were there anything fun that happened to you so far?");
        promt_saved_list.Add("How much time did you waste today, and why?");
        promt_saved_list.Add("What good things did you do today?");
    }

    public void add_entry()
    {
        System.Random random_number_generator = new System.Random();
        int index = random_number_generator.Next(promt_saved_list.Count);
        string random_prompt = promt_saved_list[index];

         Console.WriteLine($"{random_prompt}");
        string promt_response = Console.ReadLine();
        promt_list.Add(random_prompt);
        user_inputs.Add(promt_response);
    }

    public void load()
    {
        string filename = "promt_loader.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {  
            promt_list.Add(line);
        }
        
        filename = "user_loader.txt";
        lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {  
            user_inputs.Add(line);
        }          
    }

    public void save()
    {
        using (StreamWriter saver = new StreamWriter("promt_loader.txt"))
        {
        
            foreach (string promt in promt_list)
            {
                saver.WriteLine(promt);
            }
        }

        using (StreamWriter saver = new StreamWriter("user_loader.txt"))
        {
        
            foreach (string input in user_inputs)
            {
                saver.WriteLine(input);
            }
        }
    }

    public void Display()
    {
         int List_entries = promt_list.Count();

         for(int i = 0 ; i < List_entries; i++)
         {
            Console.WriteLine(promt_list[i]);
            Console.WriteLine(user_inputs[i]);
            Console.WriteLine();
         }


    }
}