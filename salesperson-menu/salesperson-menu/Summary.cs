using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace salesperson_menu
{
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();

            double totalSales = 0.0;
            double totalCommission = 0.0;
            double totalPay = 0.0;

            foreach(Salesperson p in Program.Salespersons)
            {
                totalSales += p.Sales;
                totalCommission += p.CalculateCommission();
                totalPay += p.CalculateTotalPay();
            }

            SalesTextBox.Text = "$" + totalSales.ToString("0.00");
            CommissionTextBox.Text = "$" + totalCommission.ToString("0.00");
            PayTextBox.Text = "$" + totalPay.ToString("0.00");
        }
    }
}
