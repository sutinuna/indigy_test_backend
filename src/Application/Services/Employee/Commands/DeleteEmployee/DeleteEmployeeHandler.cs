using AutoMapper;
using MediatR;

namespace Application.Services.Employee.Commands.DeleteEmployee;

public class DeleteEmployeeHandler(IMapper mapper) : IRequestHandler<DeleteEmployeeRequest, DeleteEmployeeResponse>
{
    public async Task<DeleteEmployeeResponse> Handle(DeleteEmployeeRequest request, CancellationToken cancellationToken)
    {
        var result = new DeleteEmployeeResponse();

        return result;
    }
}