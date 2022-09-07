using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Testing;

using Shouldly;

using Wishlist.Contracts.Http;

namespace Wishlist.IntegrationTests;

public class WishlistApiTests
{
    private readonly HttpClient _client;

    public WishlistApiTests()
    {
        var application = new WebApplicationFactory<Program>();
        _client = application.CreateClient();
    }

    [Fact]
    public async Task CreateWishlistShouldReturnWishlistId()
    {
        // Arrange
        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        var cancellationToken = cts.Token;

        var request = new CreateWishlistRequest
        {
            Name = Guid.NewGuid().ToString()
        };

        // Act
        using var response = await _client.PutAsJsonAsync("api/wishlist", request, cancellationToken: cancellationToken);

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.Created);

        var result = await response.Content.ReadFromJsonAsync<CreateWishlistResponse>();
        result.Id.ShouldBeGreaterThan(0);
    }
}