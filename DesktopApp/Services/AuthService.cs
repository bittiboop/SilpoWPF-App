namespace DesktopApp.Services;

public class AuthService
{
    private string _currentUser;
    private bool _isAuthenticated;

    public AuthService()
    {
        _isAuthenticated = false;
        _currentUser = string.Empty;
    }

    public bool Login(string username, string password)
    {
        if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
        {
            _currentUser = username;
            _isAuthenticated = true;
            return true;
        }
        return false;
    }

    public void Logout()
    {
        _currentUser = string.Empty;
        _isAuthenticated = false;
    }

    public bool IsAuthenticated()
    {
        return _isAuthenticated;
    }

    public string GetCurrentUser()
    {
        return _currentUser;
    }
}