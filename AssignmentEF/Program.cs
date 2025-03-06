using System.Text.Json;
using AssignmentEF.Models;
using AssignmentEF.Models.Context;

namespace AssignmentEF
{
    internal class Program
    {
        static void Main()
        {
            //var Context = new CompanyDbContext();
            #region Inheritance Mapping
            //Inheritance Mapping
            // Ef Core Support 3 Ways For Mapping Inheritance
            // 1. Default => TPH
            // 2. TPT
            // 3. TPCC

            //var partTime1 = new PartTimeEmployee
            //{
            //    Name = "Ahmed",
            //    Email = "Ahmed@gmail.com",
            //    Address = "Hadayek Helwan",
            //    HourlyRate = 8.5m,
            //    HoursWorked = 10,
            //};
            //var partTime2 = new PartTimeEmployee
            //{
            //    Name = "Hossam",
            //    Email = "Hossam@gmail.com",
            //    Address = "Maadi",
            //    HourlyRate = 9.5m,
            //    HoursWorked = 13,
            //};
            //var fullTime1 = new FullTimeEmployee
            //{
            //    Name = "Mohamed",
            //    Email = "Mohamed@gmail.com",
            //    Address = "Nasr City",
            //    MonthlySalary = 5000
            //};
            //var fullTime2 = new FullTimeEmployee
            //{
            //    Name = "Kareem",
            //    Email = "Kareem@gmail.com",
            //    Address = "Helwan",
            //    MonthlySalary = 4500.00m
            //};

            //Context.Employees.AddRange(partTime1,partTime2,fullTime1,fullTime2);
            //Context.Set<PartTimeEmployee>().AddRange(partTime1, partTime2);
            //Context.Set<FullTimeEmployee>().AddRange(fullTime1, fullTime2);
            //Context.SaveChanges();
            #endregion
            #region Data Seeding
            //var data = File.ReadAllText("");

            // Create Employees
            //var employees = JsonSerializer.Deserialize<IEnumerable<Employee>>(data);

            //Context.Set<Employee>().AddRange(employees);
            //Context.SaveChanges();
            #endregion
            #region Insert Data With Relations
            //var dept1 = new Department { Name = "Human Resources" };
            //var dept2 = new Department { Name = "Finance" };
            //var dept3 = new Department { Name = "IT" };

            //dept1.Employees=[
            //   new Employee { Name = "Ahmed",Email="ahmed@gmail.com",Address="maadi"},
            //   new Employee { Name = "Hossam",Email="hossam@gmail.com",Address="nasr city"},
            //   new Employee { Name = "Mahmoud",Email="mahmoud@gmail.com",Address="6 october"}
            // ];

            //Console.WriteLine(Context.Entry(dept1).State);

            //Context.Departments.Add(dept1);
            //Console.WriteLine(Context.Entry(dept1).State);

            //foreach (var item in dept1.Employees)
            //{
            //     Console.WriteLine(Context.Entry(item).State);
            //}

            //Context.Departments.Add(new Department { Name = "Finance" });

            //var employees2 = new List<Employee> 
            //{
            //   new Employee { Name = "Atef",Email="atef@gmail.com",Address="Giza",DepartmentId = 2},
            //   new Employee { Name = "Kareem",Email="kareem@gmail.com",Address="Alex",DepartmentId = 2},
            //   new Employee { Name = "Ameer",Email="ameer@gmail.com",Address="Cairo",DepartmentId = 2}
            //};
            //Context.Employees.AddRange(employees2);
            //Context.SaveChanges();
            #endregion
        }
    }
}
