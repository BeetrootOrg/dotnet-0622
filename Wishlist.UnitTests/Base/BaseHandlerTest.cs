using System;

using MediatR;

using Wishlist.Domain.Database;
using Wishlist.UnitTests.Helpers;

namespace Wishlist.UnitTests.Base;

public abstract class BaseHandlerTest<TRequest, TResult> : IDisposable
    where TRequest : IRequest<TResult>
{
    protected readonly WishlistDbContext DbContext;
    protected readonly IRequestHandler<TRequest, TResult> Handler;

    public BaseHandlerTest()
    {
        DbContext = DbContextHelper.CreateTestDb();
        Handler = CreateHandler();
    }

    protected abstract IRequestHandler<TRequest, TResult> CreateHandler();

    public void Dispose()
    {
        DbContext.Database.EnsureDeleted();
        DbContext.Dispose();
    }
}