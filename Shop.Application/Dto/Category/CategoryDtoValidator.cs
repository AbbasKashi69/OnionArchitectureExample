

using FluentValidation;

namespace Shop.Application.Dto.Category
{
    public class CategoryDtoValidator : AbstractValidator<CategoryDto>
    {
        public CategoryDtoValidator()
        {
            RuleFor(r => r.Name)
                .NotEmpty()
                .WithMessage("نام اجباری است.")
                .NotNull()
                .WithMessage("نام اجباری است.");
        }
    }
}
