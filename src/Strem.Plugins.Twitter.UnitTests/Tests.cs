using Microsoft.Extensions.Logging;
using Moq;
using Strem.Core.Events.Bus;
using Strem.Core.State;
using Strem.Plugins.Twitter.Plugin;
using Strem.Plugins.Twitter.Services.ApiClient;
using Strem.Plugins.Twitter.Services.OAuth;

namespace Strem.Plugins.Twitter.UnitTests;

public class Tests
{
    [Fact]
    public async Task should_correctly_setup_plugin()
    {
        var mockEventBus = new Mock<IEventBus>();
        var mockAppState = new Mock<IAppState>();
        var mockLogger = new Mock<ILogger<TwitterPluginStartup>>();
        var mockApiClient = new Mock<ITwitterApiClient>();
        var mockOAuthClient = new Mock<ITwitterOAuthClient>();

        var analyticsPluginStartup = new TwitterPluginStartup(mockEventBus.Object, mockAppState.Object, mockLogger.Object, mockApiClient.Object, mockOAuthClient.Object);

        await analyticsPluginStartup.SetupPlugin();
    }
}