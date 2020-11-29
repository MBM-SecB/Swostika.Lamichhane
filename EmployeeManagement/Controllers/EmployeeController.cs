using System.Linq;
using EmployeeManagement.Data;
using Microsoft.AspNetCore.Mvc;
public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        var db = new EMSContext();
        var employees = db.Employees.ToList();
        

        // List<Employee> employees = new List<Employee>();


        return View(employees);
    }

    public ActionResult Detail(string firstName)
    {
        var employees = Employee.GetEmployees();
        var employee = employees.Where(x => x.FirstName == firstName).First();
        return View(employee);
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult<bool> Add(Employee employee)
    {
        return true;
    }
}