using CustomConsole;

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
				// Calculate the monthly salary for the current employee
				double monthlySalary = employee.CalculateMonthlySalary();
				
				// Display the monthly salary for the current employee
				Console.WriteLine($"{employee.Name} ({employee.Title}): Monthly Salary = ${monthlySalary:F}");
				
				// Add the monthly salary for the current employee to the total monthly salary
				totalMonthlySalary += monthlySalary;
			}

			// Display the total monthly salary for all employees
			ConsoleHelper.PrintBlank();
			Console.WriteLine($"Total monthly salary for all employees: ${totalMonthlySalary:F}");
			
			// Pause the program and wait for the user to press a key to end the program
			ConsoleHelper.PrintBlank();
			ConsoleHelper.HaltProgram();
		}
	}
}