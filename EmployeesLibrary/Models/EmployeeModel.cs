namespace EmployeesLibrary.Models
{
    public class EmployeeModel
    {
        public EmployeeModel(int empId, int projectId, DateTime dateFrom, DateTime dateTo)
        {
            EmpId = empId;
            ProjectId = projectId;
            DateFrom = dateFrom;
            DateTo = dateTo;
        }

        public int EmpId { get; }
        public int ProjectId { get; }
        public DateTime DateFrom { get; }
        public DateTime DateTo { get; } 

    }
}
