

using FluentValidation;

namespace Shop.Application.Dto.Product
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(r => r.Name)
                .NotEmpty()
                .WithMessage("نام اجباری است.")
                .NotNull()
                .WithMessage("نام اجباری است.");

            RuleFor(r => r.Price)
                .GreaterThanOrEqualTo(0)
                .WithMessage("قیمت را اشتباه وارد کرده اید.");
        }
    }
}
