using Strem.Plugins.Twitter.Types;

namespace Strem.Plugins.Twitter.Components;

public class ScopeCollections
{
    public static string[] ReadTweetScopes = new[] { Scopes.ReadTweet };
    public static string[] ManageTweetScopes = new[] { Scopes.WriteTweet, Scopes.ModerateTweet, Scopes.ReadUsers };
}