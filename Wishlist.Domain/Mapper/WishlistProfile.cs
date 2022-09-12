using AutoMapper;

namespace Wishlist.Domain.Mapper;

internal class WishlistProfile : Profile
{
    public WishlistProfile()
    {
        CreateMap<Wishlist.Contracts.Database.Present, Wishlist.Contracts.Http.Present>();
        CreateMap<Wishlist.Contracts.Database.Wishlist, Wishlist.Contracts.Http.Wishlist>();
    }
}