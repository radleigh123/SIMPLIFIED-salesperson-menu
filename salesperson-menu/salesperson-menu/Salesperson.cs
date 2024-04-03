using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace salesperson_menu
{
    internal class Salesperson
    {
        public string Name { get; set; }
        public double Sales { get; set; }
        public const double COMMISSION = 0.15;
        public const int QUOTA = 1000;
        public const double BASE_PAY = 250.00;

        public Salesperson(string name, double sales)
        {
            Name = name;
            Sales = sales;
        }

        public virtual double CalculateTotalPay()
        {
            if (Sales >= QUOTA)
                return BASE_PAY + (Sales * COMMISSION);

            return BASE_PAY;
        }

        public virtual double CalculateCommission()
        {
            if (Sales >= QUOTA)
                return Sales * COMMISSION;

            return 0.0;
        }
    }
}
