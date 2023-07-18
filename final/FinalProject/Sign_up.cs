public class Sign_up : Account
{
    public string[] sign_up()
    {
        Console.WriteLine("Pleaes create your ID: ");
        _created_id = Console.ReadLine();

        Console.WriteLine("Please Create your password: ");
        _created_password = Console.ReadLine();
        
        string[] user = {_created_id, _created_password};

        return user;

    }

    public override void Display_animation()
    {
        Console.Clear();
        Console.WriteLine("Your account was successfully created.");
        Thread.Sleep(3000);
        Console.Clear();
        
    }

}