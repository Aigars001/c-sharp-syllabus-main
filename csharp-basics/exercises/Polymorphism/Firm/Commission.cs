using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Firm
{
    internal class Commission : Hourly
    {
        public double TotalSales;
        public double CommissionRate; 

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            CommissionRate = commissionRate;
            TotalSales = 0;
        }

        public void AddSales(double totalSales)
        {
            TotalSales += totalSales;
        }

        public override double Pay()
        {
            return base.Pay() + CommissionRate *  TotalSales;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nSales: " + TotalSales;
            return result;
        }

        
    }
}
