using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace salesperson_menu
{
    internal class SuperVisor : Salesperson
    {
        public SuperVisor(string name, double sales) : base(name, sales) {}

        public override double CalculateTotalPay()
        {
            if (Sales >= 2000)
            {
                return 500.00 + (Sales * 0.2);
            }
            else
            {
                return 500.00;
            }
        }

        public override double CalculateCommission()
        {
            if (Sales >= 2000)
            {
                return Sales * 0.2;
            }
            else
            {
                return 0.0;
            }
        }
    }
}
