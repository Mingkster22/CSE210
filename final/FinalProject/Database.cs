public static class Database
{
    public static List <string> id_info = new List<string>();
    public static List <string> pw_info = new List <string>();
    public static List <double> money_info = new List <double>();

    
    public static void saver()
    {
        using (StreamWriter outputFile = new StreamWriter("IDFile.txt"))
        {
           foreach (string i in id_info)
           {
                outputFile.WriteLine(i);
           }
        }

         using (StreamWriter outputFile = new StreamWriter("PWFile.txt"))
        {
             foreach (string i in pw_info)
           {
                outputFile.WriteLine(i);
           }
        }
    }  

    public static void loader()
    {

       string filepath = "C:\\Users\\ymg26\\Pictures\\Code\\CSE 210 Spring\\final\\FinalProject\\IDFile.txt";

       if(File.Exists(filepath)){

        string[] IDs = System.IO.File.ReadAllLines("IDFile.txt");

        foreach (string id in IDs)
        {
            id_info.Add(id);
        }

         string[] PWS = System.IO.File.ReadAllLines("PWFile.txt");

        foreach (string pw in PWS)
        {
            pw_info.Add(pw);
        }

       }
    
    }

    public static void money_saver()
    {
        using (StreamWriter outputFile = new StreamWriter("Moneyfile.txt"))

        foreach (double i in money_info)
        {
            outputFile.WriteLine(i);
        }
    }

    public static double money_loader(Log_in lg)
    {
        string filepath = "C:\\Users\\ymg26\\Pictures\\Code\\CSE 210 Spring\\final\\FinalProject\\moneyfile.txt";
        
        if (File.Exists(filepath))
        {
            string[] Money = System.IO.File.ReadAllLines("Moneyfile.txt");

            int counter = 0;

            foreach (string i in id_info)
            {
                if (lg.get_id() == i)
                {
                    break;
                }
                
                counter ++;
            }

            foreach(string line in Money)
            {
                 string converter = line;
                 double money = Convert.ToDouble(converter);      
                 money_info.Add(money);
            }

             double Usermoney = double.Parse(Money[counter]);
             return Usermoney;
        }

        return 0;
    }
}