using EmployeesLibrary.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeesPair
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            var services = new ServiceCollection();

            services.AddSingleton<ICalculationService, CalculationService>();
            services.AddSingleton<IEmployeePairService, EmployeePairsService>();
            services.AddSingleton<ICsvService, CsvService>();
            services.AddSingleton<MainForm>(); 

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            Application.Run(mainForm); 
        }
    }
}