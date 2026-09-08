using System;
using System.IO;

public class User
{
    public string name = "";
    public string email = "";
    public string password = "";

    public void createUser()
    {

    }

}

public class Staff : User
{
    public Staff()
    {
        
    }

    public void createUser(Staff staff,string Name, string Email, string Password)
    {
        staff.name = Name;
        staff.email = Email;
        staff.password = Password;
    }

    public void saveUser(string Name, string Email, string Password)
    {
        File.AppendAllText("staff.txt", "\n S \n" + Name + "\n" + Email + "\n" + Password + "\n E \n");
    }
}


public class Customer : User
{ 
}
