using MediatR;

namespace Application.Services.Employee.Commands.UpdateEmployee;

public class UpdateEmployeeRequest : IRequest<UpdateEmployeeResponse>
{
    public Domain.Entities.Employee? Data { get; set; }
}