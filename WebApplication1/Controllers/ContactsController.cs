using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class ContactsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Check(ContactModel contactModel)
    {
        if (ModelState.IsValid)
        {
            return Redirect("/");
        }
        return View("Index");
    }
    public void her()
    {
    }
    public void her(string her)
    {
    }
}