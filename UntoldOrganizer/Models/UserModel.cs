using System.Text.Json.Serialization;

public class User{
    public string uuid {get;set;}
    public string username {get;set;}
    [JsonIgnore]
    private string password {get;set;}
    public string email {get;set;}
    List<Character> characters = new List<Character>();
}