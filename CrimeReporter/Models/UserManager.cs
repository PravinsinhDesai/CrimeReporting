namespace CrimeReporter.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

public class UserManager{
           public static string path = @"D:\Project\CrimeReporting\CrimeReporter\wwwroot\UserList.json";
    //Serelization logic
    public static void RegInFile( List<User> ulist){

        //serelizalition
        
        var jsonList = JsonSerializer.Serialize<List<User>>(ulist);
        File.WriteAllText(path,jsonList);  
    }

    public static List<User> GetAllUser(){

        var Userjson = File.ReadAllText(path);
        List<User> users = JsonSerializer.Deserialize<List<User>>(Userjson);
        return users;

    }




}