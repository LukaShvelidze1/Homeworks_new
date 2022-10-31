using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Finance
    {
    }
}

interface FinanceOperations
{
    public void CalculateLoanPercent(int month, double AmountPerMonth);
    public void CheckUserHistory();
}

public class Bank : FinanceOperations
{
    public void CalculateLoanPercent(int month, double AmountPerMonth)
    {
        var total = month * AmountPerMonth;
           
    }

    public void CheckUserHistory()
    {
        var random = new Random();
        var randomBool = random.Next(2) == 1;
        if (randomBool == true)
        {
            CalculateLoanPercent(6, 0.05);
        }
        
        
    }
}

public class MicroFinance : FinanceOperations
{
    public void CalculateLoanPercent(int month, double AmountPerMonth)
    {
        var total = (month * AmountPerMonth) * 0.1;
    }

    public void CheckUserHistory()
    {
       bool randomBool = true;
        if (randomBool == true)
        {
            CalculateLoanPercent(6, 4);
            
        }
    }
}
