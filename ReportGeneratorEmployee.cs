namespace ReportGenerator
{
    internal class ReportGeneratorEmployee
    {
        private readonly EmployeeDB _employeeDb;
        public list<Employee> Generate_List()
        {
            var employees = new List<Employee>();
            Employee employee;

            _employeeDb.Reset();

            // Get all employees
            while ((employee = _employeeDb.GetNextEmployee()) != null)
            {
                employees.Add(employee);
            }
            return employees;
        }

    }
}
