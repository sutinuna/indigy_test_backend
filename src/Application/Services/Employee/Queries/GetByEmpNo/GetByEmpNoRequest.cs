using System.Text.Json.Serialization;
using MediatR;

namespace Application.Services.Employee.Queries.GetByEmpNo;

public class GetByEmpNoRequest : IRequest<GetByEmpNoResponse>
{
    public long EMPNO { get; set; }
}