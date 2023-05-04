using EmployeesLibrary.Models;

namespace EmployeesLibrary.Services
{
    public class CalculationService : ICalculationService 
    {
        public int CalculateOverlappingTime(EmployeeModel firstEmployee, EmployeeModel secondEmployee)
        {
            DateTime earlierDate = CalculateEarlierDate(firstEmployee, secondEmployee);
            DateTime laterDate = CalculateLaterDate(firstEmployee, secondEmployee);
            int days = Convert.ToInt32((laterDate - earlierDate).TotalDays); 
            
            return days; 
        }

        private DateTime CalculateEarlierDate(EmployeeModel firstEmployee, EmployeeModel secondEmployee)
        {
            DateTime firstEmpDateFrom = firstEmployee.DateFrom;
            DateTime secondEmpDateFrom = secondEmployee.DateFrom; 

            return firstEmpDateFrom >= secondEmpDateFrom ? firstEmpDateFrom : secondEmpDateFrom; 
        }

        private DateTime CalculateLaterDate(EmployeeModel firstEmployee, EmployeeModel secondEmployee)
        {
            DateTime firstEmpDateTo = firstEmployee.DateTo;
            DateTime secondEmpDateTo = secondEmployee.DateTo; 

            return firstEmpDateTo <= secondEmpDateTo ? firstEmpDateTo : secondEmpDateTo; 
        }
    }
}
