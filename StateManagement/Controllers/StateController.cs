using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class StateController: Controller
{
    public ViewResult First()
    {
        //satemanagement
        //1.Client side
        //1.1 cookies
        var name="swostika";
        Response.Cookies.Append("user",name);

        //1.2 Query Strings(Query Params)

        //server side
        HttpContext.Session.SetString("Address","kathmandu");

        return View();
    }

    
    public ViewResult Second(string name, int age)
    {
        var userAddress = HttpContext.Session.GetString("Address");

        //temp data
        TempData["CollegeName"]="MBMC";
    return View();
    }


      public ViewResult Third(string name, int age)
    {
        var cName=TempData["CollegeName"];
        byte value=67;

        ViewData["Name1"]="abc";
        ViewBag.Name="abc from viewbag";

    return View(value);
    }

     [HttpPost]
    public string Second(string collegeName)
    {
    return collegeName;
    }
}