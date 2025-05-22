using FluentValidation;
using Application.DTOs;
using Application.Interfaces.Courses;

namespace Application.DTOValidations
{
    public class UpdateCourseValidator : AbstractValidator<UpdateCourseDto>
    {
        public UpdateCourseValidator(ICourseRepository repository)
        {
            RuleFor(x => x.Title).NotNull()
                .NotEmpty()
                .MaximumLength(100)
                .MustAsync(async (title, cancellation) =>
                    title == null || !await repository.IsTitleDuplicateAsync(title))
                .WithMessage("The course title must be unique.");
            RuleFor(x => x.Description)
                .NotNull()
                .NotEmpty()
               .MaximumLength(500);
        }
    }

}
