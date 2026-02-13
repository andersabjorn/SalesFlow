using Microsoft.AspNetCore.Mvc;
using SalesFlow.Web.Models;

namespace SalesFlow.Web.Controllers;

public class LeadsController : Controller
{
    private static List<Lead> _leads = new();
    
    public IActionResult Index()
    {
        return View(_leads);
    }
    
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Lead lead)
    {
        lead.Id = _leads.Count + 1;
        _leads.Add(lead);
        return RedirectToAction("Index");
    }
}