using InjectionDeDependance3.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InjectionDeDependance3.Controllers
{
    [Route("api/[controller]")]
    public class SalaryController
    {
        private ISalaryCalculator Calculator { get; set; }

        public SalaryController(ISalaryCalculator injectedCalculator)
        {
            Calculator = injectedCalculator;
        }

        [HttpGet("{yearlyAmount}")]
        public Double Get(Double yearlyAmount)
        {
            Double calculatedSalary = Calculator.CalculateSalary(yearlyAmount);
            return calculatedSalary;
        }
    }
}
