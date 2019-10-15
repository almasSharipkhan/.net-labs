﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CSLab2.Controllers
{
    public class CalculatorController : Controller
    {
        //public IActionResult PlusTen(int number)
        //{
        //    ViewData["number"] = number;
        //    ViewData["result"] = number + 10;

        //    return View();
        //}
        
        [Route("[controller]/{firstNumber:int}/{secondNumber:int}")]
        public IActionResult Sum(int firstNumber, int secondNumber)
        {
            ViewData["firstNumber"] = firstNumber;
            ViewData["secondNumber"] = secondNumber;
            ViewData["result"] = firstNumber + secondNumber;

            return View();
        }
    }
}