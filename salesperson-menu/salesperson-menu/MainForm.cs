using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace salesperson_menu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
                TotalPayTextBox.Font = fontDialog.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
                TotalPayTextBox.BackColor = colorDialog.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            SalesTextBox.Text = "";

            NameTextBox.Focus();
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckIfInputCorrect()) return;

            if(superCheckBox.Checked)
            {
                SuperVisor s = new SuperVisor(NameTextBox.Text, Convert.ToDouble(SalesTextBox.Text));
                Program.Salespersons.Add(s);
                TotalPayTextBox.Text = s.CalculateTotalPay().ToString("0.00");
            }
            else
            {
                Salesperson tmp = new Salesperson(NameTextBox.Text, Convert.ToDouble(SalesTextBox.Text));
                Program.Salespersons.Add(tmp);

                TotalPayTextBox.Text = "" + tmp.CalculateTotalPay().ToString("0.00");
            }
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Summary().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Boolean CheckIfInputCorrect()
        {
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }

            if (SalesTextBox.Text == "")
            {
                MessageBox.Show("Please enter a sales amount.");
                return false;
            }
            else if(!new Regex(@"^\d*\.?\d+$").IsMatch(SalesTextBox.Text))
            {
                MessageBox.Show("Please enter a valid sales amount.");
                return false;
            }

            return true;
        }
    }
}
