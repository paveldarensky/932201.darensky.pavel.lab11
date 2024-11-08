using Microsoft.AspNetCore.Mvc;
using LW_11_WebApplication.Models;
using LW_11_WebApplication.Services;

namespace LW_11_WebApplication.Controllers
{
    // CalculatorController.cs
    public class CalculatorController : Controller
    {
        public IActionResult IndexModel()
        {
            int num1 = new Random().Next(0, 11);
            int num2 = new Random().Next(0, 11);

            int Addition = num1 + num2;
            int Subtraction = num1 - num2;
            int Multiplication = num1 * num2;
            string Division = num2 != 0 ? (num1 / (int)num2).ToString() : "На ноль делить нельзя";

            var viewModel = new Calculator()
            {
                Num1 = num1.ToString(),
                Num2 = num2.ToString(),
                Addition = Addition.ToString(),
                Subtraction = Subtraction.ToString(),
                Multiplication = Multiplication.ToString(),
                Division = Division
            };

            return View(viewModel);
        }

        public IActionResult IndexViewData()
        {
            int num1 = new Random().Next(0, 11);
            int num2 = new Random().Next(0, 11);

            ViewData["Num1"] = num1.ToString();
            ViewData["Num2"] = num2.ToString();

            int Addition = num1 + num2;
            int Subtraction = num1 - num2;
            int Multiplication = num1 * num2;
            string Division = num2 != 0 ? (num1 / (int)num2).ToString() : "На ноль делить нельзя";

            ViewData["Addition"] = Addition.ToString();
            ViewData["Subtraction"] = Subtraction.ToString();
            ViewData["Multiplication"] = Multiplication.ToString();
            ViewData["Division"] = Division;

            return View();
        }
        public IActionResult IndexViewBag()
        {
            int num1 = new Random().Next(0, 11);
            int num2 = new Random().Next(0, 11);

            ViewBag.Num1 = num1;
            ViewBag.Num2 = num2;

            ViewBag.Addition = num1 + num2;
            ViewBag.Subtraction = num1 - num2;
            ViewBag.Multiplication = num1 * num2;
            ViewBag.Division = num2 != 0 ? (num1 / (int)num2).ToString() : "На ноль делить нельзя";

            return View();
        }


        private readonly ICalculatorService _calculatorService;
        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        public IActionResult IndexServiceInjection()
        {
            int num1 = new Random().Next(0, 11);
            int num2 = new Random().Next(0, 11);

            ViewBag.Num1 = num1;
            ViewBag.Num2 = num2;

            ViewBag.Addition = _calculatorService.Add(num1, num2);
            ViewBag.Subtraction = _calculatorService.Subtract(num1, num2);
            ViewBag.Multiplication = _calculatorService.Multiply(num1, num2);
            ViewBag.Division = _calculatorService.Divide(num1, num2);

            return View("IndexServiceInjection");
        }
    }

}
