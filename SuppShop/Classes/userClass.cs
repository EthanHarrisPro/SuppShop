using System;
using System.IO;
using System.Net;

public abstract class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string AccessLevel { get; set; }

    public User(string name, string email, string password, string accesslevel)
    {
        Name = name;
        Email = email;
        Password = password;
        AccessLevel = accesslevel;
    }

    
    
    
    public void CreateUser()
    {

    }

    

}

public class Staff : User
{
    public Staff(string name, string email, string password, string accesslevel) : base(name, email, password, accesslevel)
    { 
        
    }


    new public void CreateUser()
    {

        File.AppendAllText("staff.txt", Name + "," + Email + "," + Password + "," + AccessLevel + "\n");

    }

}


class Customer : User
{

    public Customer(string name, string email, string password) : base(name, email, password,"")
    {

    }

    new public void CreateUser()
    {
        File.AppendAllText("customer.txt", Name + "," + Email + "," + Password + "\n");
    }
}
