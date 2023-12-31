﻿using BffAzureAdB2c.Server.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;

namespace BffAzureAdB2c.Server.Controllers;

[ValidateAntiForgeryToken]
[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
[AuthorizeForScopes(Scopes = new string[] { "User.ReadBasic.All user.read" })]
[ApiController]
[Route("api/[controller]")]
public class GraphApiDataController : ControllerBase
{
    private readonly MsGraphService _graphApiClientService;

    public GraphApiDataController(MsGraphService graphApiClientService)
    {
        _graphApiClientService = graphApiClientService;
    }

    [HttpGet]
    public async Task<IEnumerable<string>> Get()
    {
        var userId = User.GetNameIdentifierId();
        if (userId != null)
        {
            var userData = await _graphApiClientService.GetGraphApiUser(userId);
            if (userData == null)
                return new List<string> { "no user data" };

            return new List<string> { $"DisplayName: {userData.DisplayName}",
            $"GivenName: {userData.GivenName}", $"AboutMe: {userData.AboutMe}" };
        }

        return Array.Empty<string>();
    }
}
