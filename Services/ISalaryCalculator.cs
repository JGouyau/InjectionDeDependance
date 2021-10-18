using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjectionDeDependance3.Services
{
    public interface ISalaryCalculator
    {
        Double CalculateSalary(Double yearlyAmount);
    }
}
