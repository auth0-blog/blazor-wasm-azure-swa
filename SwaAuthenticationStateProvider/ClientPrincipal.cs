using System.Security.Claims;
public class ClientPrincipal
{
    public string IdentityProvider { get; set; }
    public string UserId { get; set; }
    public string UserDetails { get; set; }
    public IEnumerable<string> UserRoles { get; set; }
    public IEnumerable<Dictionary<String, String>> Claims { get; set; }
}