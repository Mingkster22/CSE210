class Program
{
    static void Main(string[] args)
    {
        int user_points = 0;
        int decision = 0;
        int after_decision = 0;

        List <Goal> goal_list = new List <Goal>();


        while (decision != 6)
        {

            Console.WriteLine($"You have {user_points} points.");

            Console.WriteLine("1. Create New Goal\n" +
            "2. List Goals\n" +
            "3. Save Goals\n" +
            "4. Load Goals\n" +
            "5. Record Goals\n" +
            "6. Quit"
            );

            Console.WriteLine("Select a choice from the menu: ");
            decision = int.Parse(Console.ReadLine());

            if (decision == 1)
            {
                Console.WriteLine("1. Simple Goal\n" +
                "2. Eternal Goal\n" +
                "3. Checklist Goal\n"
                );

                Console.WriteLine("Which type of goal would you like to create?");
                after_decision = int.Parse(Console.ReadLine());
                
                if (after_decision == 1)
                {
                    Simple_Goal sg = new Simple_Goal();
                    Console.WriteLine("What is the name of your goal?");
                    sg.ask_name();
                    Console.WriteLine("What is a short description of it?");
                    sg.ask_description();
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    sg.ask_points();
                    goal_list.Add(sg);
                }
                else if (after_decision == 2)
                {
                    Console.WriteLine("Step 2");
                    Eternal_Goal eg = new Eternal_Goal();
                    Console.WriteLine("What is the name of your goal?");
                    eg.ask_name();
                    Console.WriteLine("What is a short description of it?");
                    eg.ask_description();
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    eg.ask_points();
                    goal_list.Add(eg);
                }

                else if (after_decision == 3)
                {
                    Check_list_Goal clg = new Check_list_Goal();
                    Console.WriteLine("What is the name of your goal?");
                    clg.ask_name();
                    Console.WriteLine("What is a short description of it?");
                    clg.ask_description();
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    clg.ask_points();
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                    clg.how_many_times();
                    Console.WriteLine("What is the bonus for accomplishing it that many times?");
                    clg.bonus_accomplish();
                    goal_list.Add(clg);
                }

            }

            else if (decision == 2)
            {
                int logo_number = 1;
                foreach (Goal i in goal_list)
                {
                    Console.Write($"{logo_number}. ");
                    i.Display_goal();
                    logo_number += 1;
                }
            }

            else if (decision == 3)
            {
                string fileName = "myFile.txt";
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Goal i in goal_list)
                    outputFile.WriteLine(i.save_goal());
                };
            }

            else if (decision == 4)
            {
                
            }

            else if (decision == 5)
            {
                int logo_number = 1;
                foreach (Goal i in goal_list)
                {
                    Console.Write($"{logo_number}. ");
                    i.Display_goal();
                    logo_number += 1;
                }
                Console.WriteLine("Which goal would you like to display?: ");
                int choose = int.Parse(Console.ReadLine());

                choose -= 1;

                goal_list[choose].complete_goal(user_points);

                
            }
        }
    }       
}