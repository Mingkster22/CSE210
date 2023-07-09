public abstract class Account
{
    protected string _id;
    protected int _password;
    protected string _created_id;
    protected int _created_password;
    protected double _money;

    protected List <string> id_info = new List<string>();
    protected List <int> pw_info = new List <int>();

}
