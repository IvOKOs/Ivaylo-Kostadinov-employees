using EmployeesLibrary.Models;

namespace EmployeesLibrary.Services
{
    public class CsvService : ICsvService
    {
        private readonly string filter = "All Files (*.*)|*.*"; 
        public string Filter {
            get
            {
                return filter; 
            }
        } 

        private EmployeeModel ConvertLineFromCsv(string csvLine, string format)
        {
            string[] values = csvLine.Split(',');

            EmployeeModel employee = new EmployeeModel
            {
                EmpId = Convert.ToInt32(values[0]),
                ProjectId = Convert.ToInt32(values[1]),
                DateFrom = ConvertDateFormat(values[2], format),
                DateTo = ConvertDateFormat(values[3], format) 
            };
            return employee;
        }

        private string ConvertDateFormat(string value, string format)
        {
            DateTime dateTime = DateTime.Now;

            if(value != "NULL")
            {
                dateTime = DateTime.Parse(value);
            }

            string date = dateTime.ToString(format); 
            return date; 
        }

        public List<EmployeeModel> ConvertFileToObject(string filePath, string format)
        {
            List<EmployeeModel> employeeRecords = File.ReadAllLines(filePath)
                                                        .Skip(1)
                                                        .Select(e => ConvertLineFromCsv(e, format))
                                                        .ToList();
            return employeeRecords;
        }

    }
}
