using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Lab_Take_2.Models;

namespace MVC_Lab_Take_2.Controllers
{
    public class MathsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddNumbers()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNumbers(int num1, int num2)
        {
            string sum = Maths.Add(num1, num2);
            return View("Results", sum);
        }
        [HttpGet]
        public IActionResult DivideNumbers()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DivideNumbers(int num1, int num2)
        {
            string result = Maths.Divide(num1, num2);
            return View("Results", result);
        }
        public IActionResult Results()
        {
            return View();
        }
        
    }
}