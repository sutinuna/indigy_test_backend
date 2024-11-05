using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Infratructure.Database;

public class EmployeeDBContext : DbContext
{
    public DbSet<Employee> Employees;
}