using FluentValidation;

using Wishlist.Contracts.Http;

namespace Wishlist.Api.Validation;

internal class CreatePresentRequestValidator : AbstractValidator<CreatePresentRequest>
{
    public CreatePresentRequestValidator()
    {
        RuleFor(x => x.Name).NotNull().Length(1, 100);
        RuleFor(x => x.Comment).Length(1, 500);
    }
}