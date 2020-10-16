using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Display(Name = "First Name")]
    [Required]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    public string Address { get; set; }

    public char Gender { get; set; } = 'F';

    public double Salary { get; set; }

    public static List<Employee> GetEmployees()
    {
        var employee1 = new Employee()
        {
            FirstName = "Random",
            LastName = "Guy",
            Address = "NoLand",
            Salary = 00000

        };
        var employee2 = new Employee { FirstName = "swostika", LastName = "Lamichhane", Address = "Ktm", Salary = 500 };
        var employee3 = new Employee { FirstName = "Rabina", LastName = "Karki", Address = "Ktn", Salary = 300 };
        var employee4 = new Employee { FirstName = "Kritika", LastName = "Lamichhane", Address = "Ktm", Salary = 15000 };
        var employee5 = new Employee { FirstName = "sam", LastName = "Pal", Address = "Poland", Gender = 'M', Salary = 400 };
        var employee6 = new Employee { FirstName = "sammy", LastName = "Swift", Address = "Norway", Gender = 'M', Salary = 200 };

        var employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6 };
        return employees;
    }
}