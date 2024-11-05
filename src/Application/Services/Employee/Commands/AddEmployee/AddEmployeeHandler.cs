using AutoMapper;
using MediatR;

namespace Application.Services.Employee.Commands.AddEmployee;

public class AddEmployeeHandler(IMapper mapper) : IRequestHandler<AddEmployeeRequest, AddEmployeeResponse>
{
    public async Task<AddEmployeeResponse> Handle(AddEmployeeRequest request, CancellationToken cancellationToken)
    {
        var result = new AddEmployeeResponse();

        return result;
    }
}