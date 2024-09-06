using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Fizzbuzz.Models;

namespace Fizzbuzz
{
    public interface ICalculation
    {
       string GetCalculationResults(MixedDataModel values);
    }
}
