namespace EmployeeProgram
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a list of employees
			List<Employee> employees = new List<Employee>
			{
				new Manager("John", "Manager", 60000, 5000),
				new Engineer("Alice", "Engineer", 50000, 10),
				new Salesperson("Bob", "Salesperson", 45000, 2000)
			};

			// Calculate and display the total monthly salary for all employees
			double totalMonthlySalary = 0;
			foreach (var employee in employees)
			{
				double monthlySalary = employee.CalculateMonthlySalary();
				Console.WriteLine($"{employee.Name} ({employee.Title}): Monthly Salary = ${monthlySalary:F2}");
				totalMonthlySalary += monthlySalary;
			}

			Console.WriteLine($"Total Monthly Salary for All Employees: ${totalMonthlySalary:F2}");
		}
	}
}