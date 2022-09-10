using FluentValidation;

using Wishlist.Contracts.Http;

namespace Wishlist.Api.Validation;

internal class CreateWishlistRequestValidator : AbstractValidator<CreateWishlistRequest>
{
    public CreateWishlistRequestValidator()
    {
        RuleFor(x => x.Name).Length(1, 100).NotNull();
    }
}