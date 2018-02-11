using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MathProgram.Models;

namespace MathProgram.Controllers{
    public class MathController : Controller{
        public IActionResult Add(double x, double y){
            double result = x + y;
            result.ToString();
            ViewData["Message"]="Addition Result: " + result;
            return View();
        }
        public IActionResult Subtract(double x, double y){
            double result = x - y;
            result.ToString();
            ViewData["Message"]="Subtraction Result: " + result;
            return View();
        }
        public IActionResult Multiply(double x, double y){
            double result = x * y;
            result.ToString();
            ViewData["Message"]="Multiplication Result: " + result;
            return View();
        }
        public IActionResult Divide(double x, double y){
            if(y > 1){
                double result = x / y;
                result.ToString();
                ViewData["Message"]="Division Result: " + result;
            }else{
                ViewData["Message"]="Division Result: No Division By Zero";
            }
            return View();
        }
        public IActionResult Modulus(double x, double y){
            if(y > 1){
                double result = x % y;
                result.ToString();
                ViewData["Message"]="Modulus Result: " + result;
            }else{
                ViewData["Message"]="Modulus Result: No Division By Zero";
            }
            return View();
        }
    }
}