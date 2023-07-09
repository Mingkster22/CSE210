public class Sign_in : Account
{
    public void sign_up()
    {
        Console.WriteLine("Pleaes create your ID: ");
        _created_id = Console.ReadLine();

        Console.WriteLine("Please Create your password: ");
        _created_password = int.Parse(Console.ReadLine());

        id_info.Add(_created_id);
        pw_info.Add(_created_password);


    }
}