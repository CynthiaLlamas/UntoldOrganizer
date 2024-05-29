public class AuthenticateResponse{
    public string uuid {get;set;}
    public string username {get;set;}
    public string email {get;set;}
    public string token {get;set;}

    public AuthenticateResponse(User user,string token){
        uuid = user.uuid;
        username = user.username;
        email = user.email;
        this.token = token;
    }
}