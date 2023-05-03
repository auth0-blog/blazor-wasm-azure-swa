using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

public class SwaAuthenticationStateProvider : AuthenticationStateProvider
{
  private readonly HttpClient _httpClient;
  private readonly AuthenticationState _anonymousUser;

  public SwaAuthenticationStateProvider(HttpClient httpClient)
  {
    _httpClient = httpClient;
    _anonymousUser = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
  }

  public override async Task<AuthenticationState> GetAuthenticationStateAsync()
  {
    try
    {
      var authenticationData = await _httpClient.GetFromJsonAsync<AuthenticationData>("/.auth/me");
      var principal = authenticationData!.ClientPrincipal;

      if (principal == null || string.IsNullOrWhiteSpace(principal.IdentityProvider))
        return _anonymousUser;

      principal.UserRoles = principal.UserRoles?.Except(new[] { "anonymous" }, StringComparer.CurrentCultureIgnoreCase).ToList();

      if (!principal.UserRoles?.Any() ?? true)
      {
        return _anonymousUser;
      }

      var identity = new ClaimsIdentity(principal.IdentityProvider);
      identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, principal.UserId));
      identity.AddClaim(new Claim(ClaimTypes.Name, principal.UserDetails));
      identity.AddClaims(principal!.UserRoles!.Select(r => new Claim(ClaimTypes.Role, r)));
      identity.AddClaims(principal!.Claims!.Select(c => new Claim(c["typ"], c["val"])));

      return new AuthenticationState(new ClaimsPrincipal(identity));
    }
    catch
    {
      return _anonymousUser;
    }
  }
}