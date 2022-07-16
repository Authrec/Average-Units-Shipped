using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class frmMain : Form
    {
        int curDay = 0;
        int input;
        double avgUnits = 0.00;
        public frmMain()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            avgUnits = 0.00;
            curDay = 1;
            txtInput.Text = "";
            lstUnits.Items.Clear();
            lblDays.Text = $"Day {curDay}";
            txtAvg.Text = $"Average per day: {avgUnits}";
            txtInput.ReadOnly = false;
            btnEnter.Enabled = true;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtAvg.Text = "Average per day: 0";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            avgUnits = 0.0;
            if (lstUnits.Items.Count == 7) return;
            if (int.TryParse(txtInput.Text, out input))
            {
                if (input < 0 || input > 1000)
                {
                    MessageBox.Show("The inputted number is not in range 0 - 1000", "Number not in range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInput.SelectAll();
                    return;
                }
                if (curDay != 7) curDay++;
                lstUnits.Items.Add(input);
                lblDays.Text = $"Day {curDay}";

                foreach (int item in lstUnits.Items)
                {
                    avgUnits += item;
                }
                avgUnits = (avgUnits / lstUnits.Items.Count);
                avgUnits = Math.Round(avgUnits, 2);

                txtAvg.Text = $"Average per day: {avgUnits}";
                txtInput.Text = "";
            }
            else
            {
                MessageBox.Show("Input must be a whole number", "Not a whole number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.SelectAll();
                return;
            }
            if (lstUnits.Items.Count == 7)
            {
                txtInput.ReadOnly = true;
                btnEnter.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
