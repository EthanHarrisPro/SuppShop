using System;
using System.IO;
using System.Net;

public abstract class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public User(string name, string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;
    }
    
    
    public void createUser()
    {

    }

    

}

public class Staff : User
{
    public Staff(string name, string email, string password) : base(name, email, password)
    { 
        
    }

    public void CreateUser()
    {

        File.AppendAllText("staff.txt", Name + "," + Email + "," + Password + "\n");

    }

}


class Customer : User
{

    public Customer(string name, string email, string password) : base(name, email, password)
    {

    }

    public void createUser()
    {
        File.AppendAllText("customer.txt", Name + "," + Email + "," + Password + "\n");
    }
}
