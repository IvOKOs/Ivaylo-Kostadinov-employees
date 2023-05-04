using EmployeesLibrary.Models;
using EmployeesLibrary.Services;
using System.Data;
using System.Globalization;

namespace EmployeesPair
{
    public partial class MainForm : Form
    {
        private ICsvService _csvService;
        private IEmployeePairService _employeePairService; 
        public MainForm(IEmployeePairService employeePairService, ICsvService csvService)
        {
            InitializeComponent();
            FillInDateFormats();
            _employeePairService = employeePairService; 
            _csvService = csvService; 
        }

        
        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            string file = null;  
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = _csvService.Filter;
            //openFileDialog.FilterIndex = 1; 
            EmployeePairModel pairLongestTime;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog.FileName; 
            }

            List<EmployeeModel> employees = _csvService.ConvertFileToObject(file); 
            if (employees.Count == 0)
            {
                MessageBox.Show("File is empty or it has invalid format. Please, choose another file",
                    "Empty file",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return; 
            }

            PopulateAllEmployeesDatagrid(employees, dateFormatsCombobox.SelectedItem.ToString()); 

            pairLongestTime = _employeePairService.GetFinalEmployeePair(employees); 

            PopulateEmployeePairDatagrid(pairLongestTime); 
        }

        private void FillInDateFormats()
        {
            DateTimeFormatInfo dateTimeFormat = new DateTimeFormatInfo();
            string[] formats = dateTimeFormat.GetAllDateTimePatterns();

            foreach (string format in formats)
            {
                dateFormatsCombobox.Items.Add(format);
            }

            dateFormatsCombobox.SelectedIndex = 1;
        }

        private void PopulateEmployeePairDatagrid(EmployeePairModel pairLongestTime)
        {
            DataTable dataTable = new DataTable(); 

            if (pairLongestTime == null)
            {
                MessageBox.Show("There was not a single pair of employees that worked together on a given project",
                    "No pair!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                //dataTable.Rows.Clear();
                empPairDatagridView.Rows.RemoveAt(0); 
                return;
            }

            empPairLabel.Visible = true; 
            empPairDatagridView.Visible = true;
            
            dataTable.Columns.Add("Employee ID #1", typeof(int));
            dataTable.Columns.Add("Employee ID #2", typeof(int));
            dataTable.Columns.Add("Project ID", typeof(int));
            dataTable.Columns.Add("Days worked", typeof(int));

            dataTable.Rows.Add(pairLongestTime.FirstEmployeeId,
                                pairLongestTime.SecondEmployeeId,
                                pairLongestTime.ProjectId,
                                pairLongestTime.Days);

            empPairDatagridView.DataSource = dataTable; 
        }

        private void PopulateAllEmployeesDatagrid(List<EmployeeModel> employees, string format) 
        {
            allEmployeesLabel.Visible = true; 
            allEmpDatagridView.Visible = true;
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpID", typeof(int));
            dt.Columns.Add("ProjectID", typeof(int));
            dt.Columns.Add("DateFrom", typeof(string));
            dt.Columns.Add("DateTo", typeof(string));

            foreach (EmployeeModel employee in employees)
            {
                string dateFrom = employee.DateFrom.ToString(format); 
                string dateTo = employee.DateTo.ToString(format); 

                dt.Rows.Add(employee.EmpId,
                    employee.ProjectId,
                    dateFrom,
                    dateTo); 
            }

            allEmpDatagridView.DataSource = dt; 
        }
        
    }
}