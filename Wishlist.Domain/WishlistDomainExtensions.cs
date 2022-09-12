using System;

using AutoMapper;

using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using Wishlist.Domain.Commands;
using Wishlist.Domain.Database;
using Wishlist.Domain.Helpers;
using Wishlist.Domain.Helpers.Interfaces;
using Wishlist.Domain.Mapper;

namespace Wishlist.Domain;

public static class WishlistDomainExtensions
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services,
        Action<IServiceProvider, DbContextOptionsBuilder> dbOptionsAction)
    {
        return services.AddMediatR(typeof(CreateWishlistCommand))
            .AddSingleton<IDateTimeProvider, DateTimeProvider>()
            .AddDbContext<WishlistDbContext>(dbOptionsAction)
            .AddSingleton(_ =>
            {
                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<WishlistProfile>();
                });

                return configuration.CreateMapper();
            });
    }
}