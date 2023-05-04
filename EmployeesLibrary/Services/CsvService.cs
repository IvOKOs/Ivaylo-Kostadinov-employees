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

        private EmployeeModel ConvertLineFromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');

            int empId = Convert.ToInt32(values[0]);
            int projectId = Convert.ToInt32(values[1]);
            DateTime dateFrom = ConvertDateFormat(values[2]);
            DateTime dateTo = ConvertDateFormat(values[3]); 

            EmployeeModel employee = new EmployeeModel(empId, projectId, dateFrom, dateTo); 

            return employee;
        }

        private DateTime ConvertDateFormat(string value)
        {
            DateTime dateTime = DateTime.Now;

            if (value != "NULL")
            {
                if (!DateTime.TryParse(value, out dateTime))
                {
                    throw new ArgumentException("A valid value was not provided", value);
                }
            }

            return dateTime;
        }

        public List<EmployeeModel> ConvertFileToObject(string filePath)
        {
            List<EmployeeModel> employeeRecords = File.ReadAllLines(filePath)
                                                        .Skip(1)
                                                        .Select(e => ConvertLineFromCsv(e))
                                                        .ToList();
            return employeeRecords;
        }

    }
}
