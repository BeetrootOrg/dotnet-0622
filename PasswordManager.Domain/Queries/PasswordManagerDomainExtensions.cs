using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using PasswordManager.Domain.Commands;
using PasswordManager.Domain.Database;

namespace PasswordManager.Domain;

public static class PasswordManagerDomainExtensions
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services, 
        Action<IServiceProvider, DbContextOptionsBuilder> dbOptionAction)
    {
        services.AddMediatR(typeof(RegisterUserCommand));
        services.AddDbContext<PasswordManagerDbContext>(dbOptionAction);
        return services;
    }
}