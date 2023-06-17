using System;

class Entry
{
    private string _promt = "";
    public string _date = "";
    public string _response = "";
    public void get_entry_data(string random_prompt)
    {
        _promt = random_prompt;
        Console.WriteLine($"{_promt}");
        _response = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }
    void promts()
    {
      
    }
    void datetime()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }
    void responses()
    {

    }
    public void Display()
    {
        Console.WriteLine($"{_promt}");
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_response}");
    }

}