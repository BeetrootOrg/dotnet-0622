using System.Net;

using Microsoft.AspNetCore.Mvc.Testing;

using PasswordManager.Contracts.Http;

using Shouldly;

namespace PasswordManager.IntegrationTests;

public class PasswordManagerApiTests
{
    private readonly HttpClient _client;

    public PasswordManagerApiTests()
    {
        var application = new WebApplicationFactory<Program>();
        _client = application.CreateClient();
    }

    [Fact]
    public async Task RegisterUserShouldRegisterNewUser()
    {
        //Arrange
        var request = new UserDTO
        {
            // UserName = Guid.NewGuid().ToString(),
            // Email = Guid.NewGuid().ToString(),
            // Password = Guid.NewGuid().ToString()
            UserName = "a3",
            Email = "a3@email.com",
            Password = "a3"
        };

        //Act
        using var response = await _client.PostAsJsonAsync("register", request);

        //Assert
        response.StatusCode.ShouldBe(HttpStatusCode.Created);

        var result = await response.Content.ReadFromJsonAsync<UserDTOResponse>();
        result.Email.ShouldBe(request.Email);
        result.UserName.ShouldBe(request.UserName);
    }
}