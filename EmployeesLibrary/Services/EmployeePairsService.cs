using EmployeesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesLibrary.Services
{
    public class EmployeePairsService : IEmployeePairService 
    {
        private ICalculationService calcService;

        public EmployeePairsService(ICalculationService calculationService)
        {
            calcService = calculationService; 
        }

        public EmployeePairModel? GetFinalEmployeePair(List<EmployeeModel> employees)
        {
            List<EmployeePairModel> pairs = GetWorkingEmployeePairs(employees);
            if (pairs.Count == 0) return null; // validation 
            if (pairs.Count == 1) return pairs[0]; // validation 
            EmployeePairModel pairLongestTime = pairs[0];

            for (int i = 1; i < pairs.Count; i++)
            {
                if (pairs[i].Days > pairLongestTime.Days)
                {
                    pairLongestTime = pairs[i];
                }
            }

            return pairLongestTime;
        }

        private List<EmployeePairModel> GetWorkingEmployeePairs(List<EmployeeModel> employees)
        {
            List<EmployeePairModel> pairs = new List<EmployeePairModel>();
            for (int i = 0; i < employees.Count; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (employees[i].EmpId == employees[j].EmpId) continue;
                    if (employees[i].ProjectId == employees[j].ProjectId)
                    {
                        int days = calcService.CalculateOverlappingTime(employees[i], employees[j]);
                        if (days <= 0) continue;
                        pairs.Add(new EmployeePairModel
                        {
                            FirstEmployeeId = employees[i].EmpId,
                            SecondEmployeeId = employees[j].EmpId,
                            ProjectId = employees[i].ProjectId,
                            Days = days
                        });
                    }
                }
            }
            return pairs; 
        }
    }
}
