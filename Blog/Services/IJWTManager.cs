namespace Blog.Services
{
    public interface IJWTManager
    {
        string Authenticate(string userid,string password);
    }
}