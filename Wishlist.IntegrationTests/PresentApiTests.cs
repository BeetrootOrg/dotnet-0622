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

public class PresentApiTests
{
    private readonly HttpClient _client;

    public PresentApiTests()
    {
        var application = new WebApplicationFactory<Program>();
        _client = application.CreateClient();
    }

    [Fact]
    public async Task CreatePresentShouldReturnNotFoundIfNoWishlist()
    {
        // Arrange
        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        var cancellationToken = cts.Token;

        var wishlistId = -1;
        var request = new CreatePresentRequest
        {
            Name = Guid.NewGuid().ToString(),
            WishlistId = wishlistId
        };

        // Act
        using var response = await _client.PutAsJsonAsync("api/present", request, cancellationToken: cancellationToken);

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.NotFound);

        var result = await response.Content.ReadFromJsonAsync<ErrorResponse>();
        result.Code.ShouldBe(ErrorCode.WishlistNotFound);
        result.Message.ShouldBe($"Wishlist {wishlistId} not found");
    }

    [Fact]
    public async Task CreatePresentShouldReturnPresentId()
    {
        // Arrange
        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
        var cancellationToken = cts.Token;

        var createWishlistRequest = new CreateWishlistRequest
        {
            Name = Guid.NewGuid().ToString()
        };

        using var wishlistResponse = await _client.PutAsJsonAsync("api/wishlist", createWishlistRequest,
            cancellationToken: cancellationToken);

        var wishlistResult = await wishlistResponse.Content.ReadFromJsonAsync<CreateWishlistResponse>();

        var request = new CreatePresentRequest
        {
            Name = Guid.NewGuid().ToString(),
            Comment = Guid.NewGuid().ToString(),
            WishlistId = wishlistResult.Id
        };

        // Act
        using var response = await _client.PutAsJsonAsync("api/present", request, cancellationToken: cancellationToken);

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.Created);

        var result = await response.Content.ReadFromJsonAsync<CreatePresentResponse>();
        result.Id.ShouldBeGreaterThan(0);
    }

    [Theory]
    [InlineData(null, "abc")]
    [InlineData("jpgUQN5NWLteLe6yY1N9irywwcf5nuUnnY2tSVNFWsSFeIJVyOtgR9qYBNurvUlkNyTSK09JJwVDRBAndqdeLGtyD2Drxj1QJQxS9hfhopXYsuPqUFVQBuThm0NdCRmKFXWRGO8W3SAedf6620uZK0cZT0NhaLXhy7DmuOQAOk0T5KGu1CXcLnjTeRC903bryQUokJ6I", "abc")]
    [InlineData("abc", "yoASFBoIWFdnTah6oKdrgczp7wlTI7ye8WFlK0CletbZJwLiw6vl7qDrcbtQWvoZMTPFh7xpz6JOhbeHXqLw2eZ0eWrdSl4sdT6Nlt97vjfKFbnbERAjrKWam3NzRMJj01B9LUZQZI3QS65MfB9jhKkNgfi6h0zKYP52c1KlQOjgYj3R65gmHjJrssJR9bWOzIccjIcSIxSXDUfOI64iV63uuA3pvwNO9EFgVdvUIVgd93if0mNdkOzCycp9FN3HEaPrC3vi6waIZcPwOV5Hscxlqim2pE0kcLTiP3XSdAodzg2gZ2mUGgfGExLvuZEE8nOIlXzxknnfhU0LU1vQwglRXYRcYyDQQSG5ulrFRBgSL9teXLmrMDiFPiyt81JJPViqpHfU5Bw1oHYWSD7T4afrwy7zYfed2v1SjvRbE7tGYpBHiSSnNQ5nhyu4IvyUKzgE8CHDPYWFmOvhhNXAWkJ47LawzZ5PsusgSZ6OtSPYGTgmUc6uRye21NfOXrVtCN3g5l0SextrDWcxiNxnmRcwdNlSKqb0bvr2lxJuQVAzYWY8KN3pO6bp6Nt0LahLAPRb1IUwRlXiDakMRYSHBAcf")]
    public async Task CreatePresentShouldReturnBadRequest(string name, string comment)
    {
        // Arrange
        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
        var cancellationToken = cts.Token;

        var createWishlistRequest = new CreateWishlistRequest
        {
            Name = Guid.NewGuid().ToString()
        };

        using var wishlistResponse = await _client.PutAsJsonAsync("api/wishlist", createWishlistRequest,
            cancellationToken: cancellationToken);

        var wishlistResult = await wishlistResponse.Content.ReadFromJsonAsync<CreateWishlistResponse>();

        var request = new CreatePresentRequest
        {
            Name = name,
            Comment = comment,
            WishlistId = wishlistResult.Id
        };

        // Act
        using var response = await _client.PutAsJsonAsync("api/present", request, cancellationToken: cancellationToken);

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);

        var result = await response.Content.ReadFromJsonAsync<ErrorResponse>();
        result.Code.ShouldBe(ErrorCode.BadRequest);
        result.Message.ShouldBe("invalid request");
    }
}