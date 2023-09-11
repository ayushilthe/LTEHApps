using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using LTEHApps.Models; // Replace with your model namespace
using Microsoft.EntityFrameworkCore;
using LTEHApps.Data;

namespace LTEHApps.Controllers
{
    public class ConflictController : Controller
    {
        private  readonly CWDbContext _context;

        public ConflictController(CWDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Conflict()
        {

            return View();
        }

        //This action handles the form submission
        [HttpPost] // Indicates that this action responds to HTTP POST requests
        [ValidateAntiForgeryToken]
        public IActionResult Conflict(Conflict model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Save the data to the database
                    _context.Conflicts.Add(model);
                    _context.SaveChanges();

                    // Redirect to a thank you page or a success page
                    return RedirectToAction("ThankYou");
                }
                catch (Exception ex)
                {
                    // Handle the exception, log it, or return an error view
                    ModelState.AddModelError("", "An error occurred while saving the data.");
                    return View(model);
                }
            }

            // If ModelState is not valid, return the form view with validation errors
            return View(model);
        }
        public IActionResult ThankYou()
        {
            return View();
        }



    }
}
