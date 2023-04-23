using EmployeesLibrary.Models;

namespace EmployeesLibrary.Services
{
    public interface ICsvService
    {
        string Filter { get; }
        List<EmployeeModel> ConvertFileToObject(string filePath, string format); 
    }
}