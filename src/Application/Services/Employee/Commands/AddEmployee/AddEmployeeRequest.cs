using MediatR;

namespace Application.Services.Employee.Commands.AddEmployee;

public class AddEmployeeRequest : IRequest<AddEmployeeResponse>
{
    public Domain.Entities.Employee? Data { get; set; }
}