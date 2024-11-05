using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Employee
{
    [Key]
    public long EMPNO { get; set; }
    public string FIRST_NAME { get; set; }
    public string LAST_NAME { get; set; }
    public string DESIGNATION { get; set; }
    public DateTime HIREDATE { get; set; }
    public decimal SALARY { get; set; }
    public string COMM { get; set; }
    public int DEPTNO { get; set; }
}