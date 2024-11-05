using Application.Services.Employee.Commands.AddEmployee;
using Application.Services.Employee.Commands.DeleteEmployee;
using Application.Services.Employee.Commands.UpdateEmployee;
using Application.Services.Employee.Queries.GetByEmpNo;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

public class EmployeeController(IMediator _mediator, IWebHostEnvironment _hostEnvironment) : ControllerBase
{
    [HttpGet]
    [Route("api/v1/employee")]
    public async Task<IActionResult> GetEmployee(GetByEmpNoRequest query)
    {
        try
        {
            var result = _mediator.Send(query);
            
            return Ok(result.Result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost]
    [Route("api/v1/employee")]
    public async Task<IActionResult> AddEmployee(AddEmployeeRequest request)
    {
        try
        {
            var result = _mediator.Send(request);
            
            return Ok(result.Result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPut]
    [Route("api/v1/employee")]
    public async Task<IActionResult> UpdateEmployee(UpdateEmployeeRequest request)
    {
        try
        {
            var result = _mediator.Send(request);
            
            return Ok(result.Result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpDelete]
    [Route("api/v1/employee")]
    public async Task<IActionResult> DeleteEmployee(DeleteEmployeeRequest request)
    {
        try
        {
            var result = _mediator.Send(request);
            
            return Ok(result.Result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}