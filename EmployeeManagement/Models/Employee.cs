using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    public int Id { get; set; }
    
    [Display(Name = "First Name")]
    [Required (ErrorMessage="We need first name")] 
    public string FirstName { get; set; }

    [Required (ErrorMessage="We need last name")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    public string Address { get; set; }

    public char Gender { get; set; } = 'F';

    public double Salary { get; set; }
}