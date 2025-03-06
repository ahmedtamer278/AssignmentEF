using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AssignmentEF.Models.Context;

namespace AssignmentEF.Models
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public int EmployeeId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public Department Department { get; set; }
        public int? DepartmentId { get; set; }

    }
    //public class PartTimeEmployee : Employee
    //{ 
    //    public int HoursWorked { get; set; }
    //    public decimal HourlyRate { get; set; }

    //    public override string ToString()
    //    {
    //        return $"PartTimeEmployee : ID : {EmployeeId} \nName : {Name}\n Email : {Email}\n Adress : {Address}\n HoursWorked : {HoursWorked}\n HourlyRate : {HourlyRate} ";
    //    }
    //}
    //public class FullTimeEmployee : Employee
    //{ 
    //    public decimal MonthlySalary { get; set; }

    //    public override string ToString()
    //    {
    //        return $"PartTimeEmployee : ID : {EmployeeId} \nName : {Name}\n Email : {Email}\n Adress : {Address}\n MonthlySalary : {MonthlySalary} ";
    //    }
    //}

}
