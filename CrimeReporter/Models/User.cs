namespace CrimeReporter.Models;
[Serializable]
public class User{

    public string fname{get;set;}
    public string lname{get;set;}
    public string email{get;set;}
    public string password{get;set;}

    public User(string fname,string lname,string email,string password)
    {
        this.fname=fname;
        this.lname=lname;
        this.email=email;
        this.password=password;
    }


}