using Strem.Core.Variables;

namespace Strem.Plugins.Twitter.Variables;

public class TwitterVars
{
    // Generic
    public static readonly string Context = "twitter";
    
    // OAuth (app)
    public static readonly VariableEntry OAuthToken = new(CommonVariables.OAuthAccessToken, Context);
    public static readonly VariableEntry OAuthRefreshToken = new(CommonVariables.OAuthRefreshToken, Context);
    public static readonly VariableEntry TokenExpiry = new("token-expiry", Context);
    public static readonly VariableEntry OAuthScopes = new("oauth-scopes", Context);
    
    // App
    public static readonly VariableEntry ClientId = new("client-id", Context);
    
    // User (app)
    public static readonly VariableEntry UserId = new("userId", Context);
    public static readonly VariableEntry Username = new("username", Context);
}