using AutoMapper;
using MediatR;

namespace Application.Services.Employee.Commands.UpdateEmployee;

public class UpdateEmployeeHandler(IMapper mapper) : IRequestHandler<UpdateEmployeeRequest, UpdateEmployeeResponse>
{
    public async Task<UpdateEmployeeResponse> Handle(UpdateEmployeeRequest request, CancellationToken cancellationToken)
    {
        var result = new UpdateEmployeeResponse();

        return result;
    }
}