namespace Foodle.Application.Services.Authentication;

public interface IauthenticationService
{
    AuthenticationResult Register(string firstName, string lastName, string email, string password);
    AuthenticationResult Login(string email, string password);    
}