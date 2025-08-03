using Microsoft.AspNetCore.Mvc;
using South_African_Municipal_Services_Delivery.Models.ViewModels;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace South_African_Municipal_Services_Delivery.Controllers
{
    public class ServiceDelivery : Controller
    {
        public static List<string> Issues = new List<string>();


        [HttpGet]
        public IActionResult ReportIssues() {


            return View();

        }

        [HttpPost]
        public IActionResult ReportIssues(ReportIssuesViewModel model)
        {

          string newrecord = $"{model.Location} | {model.Category} | {model.Description}";
            //string newrecord = $"{"Scottburgh"} | {"Sanitation"} | {"We are having troubles with water shortages"}";

          Issues.Add(newrecord);

          TempData["SuccessMessage"] = "Complaint was successfully lodged, look out for our replies on the View Reports page."; 
            
          return RedirectToAction("ViewReports");
            


        }

        public IActionResult ViewReports()
        {

            return View(Issues);
        }



    }
}
