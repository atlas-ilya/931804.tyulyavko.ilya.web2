using System;
using Microsoft.AspNetCore.Mvc;
using lab1.Models;


namespace lab1.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UsingModelCalc()
        {

            Model l = Calculate();

            return View(l);

        }

        public IActionResult ViewDataCalc()
        {

            ViewData["data"] = Calculate();

            return View();


        }

        public IActionResult ViewBagCalc()
        {
            ViewBag.data = Calculate();

            return View();

        }

        public IActionResult ServiceInjectionCalc()
        {

            return View();
        }

        public Model Calculate()
        {
            var rand = new Random();
            int value = rand.Next(0, 10);
            int value2 = rand.Next(0, 10);

            int divRes;
            try
            {
                divRes = value / value2;
            }
            catch (DivideByZeroException)
            {
                divRes = -1;
            }

            return new Model
            {
                first = value,
                second = value2,
                resAdd = value + value2,
                resSub = value - value2,
                resDiv = divRes,
                resMult = value * value2
            };
        }
    }
}
