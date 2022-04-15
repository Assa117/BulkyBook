using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View(new salary());
        }

        [HttpPost]
        public ActionResult Index(salary s)
        {
            s.Salary = 1000;

            if (s.Children == 1)
            {
                s.Salary = s.Salary + 65;
            }
            else if (s.Children == 2)
            {
                s.Salary = s.Salary + 130;
            }
            else if (s.Children == 3)
            {
                s.Salary = s.Salary + 195;
            }
            else if (s.Children == 1)
            {
                s.Salary = s.Salary + 260;
            }
            else if (s.Children == 1)
            {
                s.Salary = s.Salary + 325;
            }



            if (s.EducationLvl == "TEI")
            {
                s.Salary = s.Salary + 50;
            }
            if (s.EducationLvl == "AEI")
            {
                s.Salary = s.Salary + 70;
            }
            if (s.EducationLvl == "MA")
            {
                s.Salary = s.Salary + 100;
            }
            if (s.EducationLvl == "PhD")
            {
                s.Salary = s.Salary + 150;
            }


            return View(s);
        }
    }
}
