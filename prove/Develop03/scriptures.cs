class Scriptures
{    
    public List <Word> word_list = new List<Word>();
    public List <Word> hidden_list = new List<Word>();   
    private string scripture =
    "Trust in the Lord with all thine heart and lean not" +
    "unto thine own understanding; in all thy ways" +
    "acknowledge him, and he shall direct thy paths.";

    public void scripture_spliter()
    {
        
        foreach(string i in scripture.Split(" "))
        {
            Word word = new Word(i);
            word_list.Add(word);
          
        }
    }
    public void scripture_displayer()
    {
        foreach (Word i in word_list)
        {
          Console.Write($"{i.Get_word()} ");
        }
    }

    public void word_changer()
    {
            Random rnd = new Random();
            int random = rnd.Next(0, word_list.Count);
            Word random_word = word_list[random];
            
            while (hidden_list.Contains(random_word))
            {
                random = rnd.Next(0, word_list.Count); 
                if(!hidden_list.Contains(word_list[random])){
                    
                    break;
                }
            }

                random_word = word_list[random];
                hidden_list.Add(random_word);
                random_word.Hide_word();


            
    }
    
}

