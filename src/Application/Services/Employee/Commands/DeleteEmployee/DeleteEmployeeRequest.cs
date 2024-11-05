using MediatR;

namespace Application.Services.Employee.Commands.DeleteEmployee;

public class DeleteEmployeeRequest : IRequest<DeleteEmployeeResponse>
{
    public Domain.Entities.Employee? Data { get; set; }
}