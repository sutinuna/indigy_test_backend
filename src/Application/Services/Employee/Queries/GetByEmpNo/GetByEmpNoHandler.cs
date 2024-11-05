using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Converter;
using AutoMapper;
using MediatR;

namespace Application.Services.Employee.Queries.GetByEmpNo;

public class GetByEmpNoHandler(IMapper mapper) : IRequestHandler<GetByEmpNoRequest, GetByEmpNoResponse>
{
    public async Task<GetByEmpNoResponse> Handle(GetByEmpNoRequest request, CancellationToken cancellationToken)
    {
        var result = new GetByEmpNoResponse();
        
        var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MockJson\\mockData.json");
        var json = await File.ReadAllTextAsync(filePath, cancellationToken);
        
        var options = new JsonSerializerOptions
        {
            Converters = { new CustomDateConverter() }
        };
        var employeeJson = JsonSerializer.Deserialize<List<Domain.JsonFiles.Employee>>(json, options);
        
        var employees = mapper.Map<List<Domain.Entities.Employee>>(employeeJson);
        
        result.Data = employees.FirstOrDefault(e => e.EMPNO == request.EMPNO);
        return result;
    }
}