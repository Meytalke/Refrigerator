using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refrigerator_FinalProj
{
    public partial class RefrigeratorDetails : Form
    {
        public Refrigerator r = new Refrigerator("LG", 1800, 2, true, true);
        public Motor m = new Motor(false);
        public RefrigeratorDetails()
        {
            InitializeComponent();
            txtBrand.Text = r.GetBrand();
            txtCapacity.Text = r.GetCapacity().ToString();
            txtHasFreezer.Text = r.GetHasFreezer().ToString();
            txtIsEnergyEfficient.Text = r.GetIsEnergyEfficient().ToString();
            txtNumberOfDoors.Text = r.GetNumberOfDoors().ToString();
            txtNumberOfItems.Text = r.GetItems().ToString();
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtBrand.Enabled == false)
            {
                Enable(true);
            }
            else
            {
                Enable(false);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                r.SetBrand(txtBrand.Text);
                r.SetBrand(txtCapacity.Text);
                txtHasFreezer.Text = r.GetHasFreezer().ToString();
                txtIsEnergyEfficient.Text = r.GetIsEnergyEfficient().ToString();
                txtNumberOfDoors.Text = r.GetNumberOfDoors().ToString();
            }
            Enable(false);
        }
        private void Enable(bool toEnable)
        {
            txtBrand.Enabled = toEnable;
            txtCapacity.Enabled = toEnable;
            txtHasFreezer.Enabled = toEnable;
            txtIsEnergyEfficient.Enabled = toEnable;
            txtNumberOfDoors.Enabled = toEnable;
        }
        public int Cool(Motor m)
        {

            if (m.IsCooling()) // Check if the refrigerator is already cooled
            {
                MessageBox.Show("The refrigerator is already cooling");
                return 0;
            }

            //if (r.GetItems() == 0) // Check for items in the refrigerator
            //{
            //    MessageBox.Show("The refrigerator is empty.");
            //    return 0;
            //}

            // Refrigerate items
            m.TurnOn();
            MessageBox.Show("The refrigerator is now cooling.");
            return 1;
        }

        private void previousPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCool_Click(object sender, EventArgs e)
        {
            if (Cool(m) == 1)
            {

                grpCool.Enabled = true;
            }
        }

        private void btnMinusCold_Click(object sender, EventArgs e)
        {
            if(prbColdIn.Value==0)
            {
                MessageBox.Show("It is not possible to reduce the cold");
            }
            else
            {
                prbColdIn.Value -= 20;
            }
        }

        private void btnPlusCold_Click(object sender, EventArgs e)
        {
            if (prbColdIn.Value == 100)
            {
                MessageBox.Show("It is impossible to increase the temperature");
            }
            else
            {
                prbColdIn.Value += 20;
            }
           
        }

        private void msgAboutTemp()
        {
            if (prbTempIn.Value>=0 && prbTempIn.Value <= 39)// -15 -  1 temp ->> 
            {
                lblTemp.Text = "Freezing storage";
            }
            else if(prbTempIn.Value>=40 && prbTempIn.Value<=75) // 2 - 15
            {
                lblTemp.Text = "Refrigerated storage";
            }
            else // 16-25
            {
                lblTemp.Text = "Store at room temperature";
            }

        }

        private void btnPlusTemp_Click(object sender, EventArgs e)
        {
            if (prbTempIn.Value == 99)
            {
                MessageBox.Show("It is impossible to increase the cold");
            }
            else
            {
                prbTempIn.Value += 3;
                msgAboutTemp();
            }
        }

        private void btnMinusTemp_Click(object sender, EventArgs e)
        {
            if (prbTempIn.Value == 0)
            {
                MessageBox.Show("It is not possible to reduce the temperature");
            }
            else
            {
                prbTempIn.Value -= 3;
                msgAboutTemp();
            }
        }
    }
}
