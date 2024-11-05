using FluentValidation;

namespace Application.Services.Employee.Queries.GetByEmpNo;

public class GetByEmpNoValidator : AbstractValidator<GetByEmpNoRequest>
{
    public GetByEmpNoValidator()
    {
        RuleFor(v => v.EMPNO)
            .GreaterThan(0)
            .WithMessage("EMPNO must be greater than 0");
    }
}