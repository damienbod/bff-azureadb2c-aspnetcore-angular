
using Microsoft.Graph.Models;
using Microsoft.Graph.Users.Item.GetMemberGroups;

namespace BffAzureAdB2c.Server.Services;

public class MsGraphService
{
    private readonly GraphApplicationClientService _graphApplicationClientService;

    public MsGraphService(GraphApplicationClientService graphApplicationClientService)
    {
        _graphApplicationClientService = graphApplicationClientService;
    }

    public async Task<User?> GetGraphApiUser(string userId)
    {
        var graphServiceClient = _graphApplicationClientService
            .GetGraphClientWithClientSecretCredential();

        return await graphServiceClient.Users[userId]
            .GetAsync();
    }

    public async Task<AppRoleAssignmentCollectionResponse?> GetGraphApiUserAppRoles(string userId)
    {
        var graphServiceClient = _graphApplicationClientService
            .GetGraphClientWithClientSecretCredential();

        return await graphServiceClient.Users[userId]
            .AppRoleAssignments
            .GetAsync();
    }

    public async Task<GetMemberGroupsResponse?> GetGraphApiUserMemberGroups(string userId)
    {
        var graphServiceClient = _graphApplicationClientService.GetGraphClientWithClientSecretCredential();

        var requestBody = new GetMemberGroupsPostRequestBody
        {
            SecurityEnabledOnly = true,
        };

        return await graphServiceClient.Users[userId]
            .GetMemberGroups
            .PostAsync(requestBody);
    }
}