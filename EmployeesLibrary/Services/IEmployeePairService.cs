using EmployeesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesLibrary.Services
{
    public interface IEmployeePairService
    {
        EmployeePairModel? GetFinalEmployeePair(List<EmployeeModel> employees); 
    }
}
