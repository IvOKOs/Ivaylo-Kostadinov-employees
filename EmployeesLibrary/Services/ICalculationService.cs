using EmployeesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesLibrary.Services
{
    public interface ICalculationService
    {
        int CalculateOverlappingTime(EmployeeModel firstEmployee, EmployeeModel secondEmployee); 
    }
}
