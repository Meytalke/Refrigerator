using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Refrigerator_FinalProj.Backend.Enums;
using Refrigerator_FinalProj.Backend.Model;
using Refrigerator_FinalProj.Frontend.Usre;
using System.Net;


namespace Refrigerator_FinalProj
{
    [Serializable]
    public partial class fRefrigerator : Form
    {
        ProductsManager manager;
        private Dictionary<string, List<string>> productImages;
        public fRefrigerator()
        {
            InitializeComponent();
            InitializeProductImages();
            comboBoxProducts.DataSource = Enum.GetValues(typeof(Enums_Collections.eAllPro));
            manager = new ProductsManager();
            this.FormClosing += new FormClosingEventHandler((sender, e) => saveProducts(sender, e, manager));
            this.Load += new EventHandler(LoadProducts);
        }
        public void LoadProducts(object sender, EventArgs e)
        {
            manager.LoadProductsFromFile();
        }
        public static void saveProducts(object sender, FormClosingEventArgs e, ProductsManager manager)
        {
            FileUtiles.SaveProductsToFile(manager.GetProducts());
        }
        private void btnRefrigeratorDetails_Click_1(object sender, EventArgs e)
        {
            RefrigeratorDetails RefrigeratorDetails = new RefrigeratorDetails();
            RefrigeratorDetails.Show();
        }

        private int secondsLeft = 5;
        private void btnIce_Click(object sender, EventArgs e)
        {
            //pictureice.Visible = true;
            //pictureice.Enabled = true;
            btnStart.Enabled = false;
            TimerForIce.Interval = (1 * 1000); // Sets the time between each standby time and decreases in seconds
            TimerForIce.Start();
        }

        private void TimerForIce_Tick(object sender, EventArgs e)
        {
            secondsLeft--;

            if (secondsLeft == 0) // When waiting time ends
            {
                lblIce.Text = "The ice is ready!";
                TimerForIce.Stop();
                secondsLeft = 5; // Reset the waiting time
                DialogResult res = MessageBox.Show("Would you like to take the ice?", "Take ice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    lblIce.Text = "";
                    btnStart.Enabled = true;
                    //pictureice.Visible = false;
                    //pictureice.Enabled = false;
                }
                else
                {
                    //pictureice.Visible = true;
                    //pictureice.Enabled = true;
                    btnIce.Enabled = false;
                    btnTakeIce.Visible = true;
                    btnStart.Enabled = true;
                    fruit1.Visible = false;

                }
            }
            else if (secondsLeft > 0)
            {
                lblIce.Text = "Waiting for ice: " + secondsLeft + " seconds left";
                //pictureice.Visible = true;
                //pictureice.Enabled = true;
            }

        }

        private void btnTakeIce_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Would you like to take the ice?", "Take ice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                lblIce.Text = "";
                //pictureice.Visible = false;
                //pictureice.Enabled = false;
                btnTakeIce.Visible = false;
                btnIce.Enabled = true;
            }

        }
        private int secondsLeft2 = 2;

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome back to the fridge Click on one of the categories to get started";
            lblWelcome.Location = new Point(40, 2);
            fruit1.Visible = false;
            pHome.Visible = true;
            btnIce.Visible = false;
            btnRefrigeratorDetails.Visible = false;
            btnStart.Visible = false;
            lblIce.Visible = false;
            pictureBox.Visible = false;
            pictureBox2Gif.Visible = true;
            pMoveToProducts.Visible = true;
            fruit1.Visible = false;
            dairyProduct1.Visible = false;
            beverage1.Visible = false;
            Meat1.Visible = false;
            vegetable1.Visible = false;
            //pictureice.Visible = false;
            //pictureice.Enabled = false;
        }

        private void TimerOpen_Tick(object sender, EventArgs e)
        {
            while (secondsLeft2 != 0)
            {
                secondsLeft2--;
                if (secondsLeft2 == 0)
                {
                    pictureBox2Gif.Visible = false;
                    secondsLeft2 = 2; 
                }
            }

        }

        private void pictureBox2Gif_Click(object sender, EventArgs e)
        {
            btnReturnToOpeningPage.Visible = false;
            pMoveToProducts.Visible = true;
        }

        private void btnReturnToOpeningPage_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome back to the fridge Click on one of the categories to get started";

            vegetable1.Visible = false;
            fruit1.Visible = false;
            pMoveToProducts.Visible = false;
            pictureBox2Gif.Visible = false;
            pHome.Visible = false;
            btnIce.Visible = true;
            btnRefrigeratorDetails.Visible = true;
            btnStart.Visible = true;
            lblIce.Visible = true;
            pictureBox.Visible = true;
            

            if (lblIce.Text == "The ice is ready!")
            {
                //pictureice.BringToFront();
                //pictureice.Visible = true;
                //pictureice.Enabled = true;
                btnTakeIce.Visible = true;
            }
        }

        private void lblReturnHome_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome back to the fridge Click on one of the categories to get started";
            btnIce.Visible = true;
            btnRefrigeratorDetails.Visible = true;
            btnStart.Visible = true;
            lblIce.Visible = true;
            pictureBox.Visible = true;
            pictureBox2Gif.Visible = false;
            btnReturnToOpeningPage.Visible = false;
            if (lblIce.Text == "The ice is ready!")
            {
                //panelice.Visible = true;
                //pictureice.Visible = true;
                //pictureice.Enabled = true;
                btnTakeIce.Visible = true;
            }
        }

        private void pHome_Click(object sender, PaintEventArgs e)
        {

        }

        private void pHome_Move(object sender, EventArgs e)
        {
            pMoveToProducts.Visible = false;
            pHome.Visible = false;
            btnIce.Visible = true;
            btnRefrigeratorDetails.Visible = true;
            btnStart.Visible = true;
            lblIce.Visible = true;
            pictureBox.Visible = true;
            pictureBox2Gif.Visible = false;
            btnReturnToOpeningPage.Visible = false;
            if (lblIce.Text == "The ice is ready!")
            {
                //pictureice.Visible = true;
                //pictureice.Enabled = true;
                btnTakeIce.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome back to the fridge Click on one of the categories to get started";
            pMoveToProducts.Visible = false;
            pHome.Visible = false;
            btnIce.Visible = true;
            btnRefrigeratorDetails.Visible = true;
            btnStart.Visible = true;
            lblIce.Visible = true;
            pictureBox.Visible = true;
            pictureBox2Gif.Visible = false;
            btnReturnToOpeningPage.Visible = false;
            if (lblIce.Text == "The ice is ready!")
            {
                //pictureice.Visible = true;
                //pictureice.Enabled = true;
                btnTakeIce.Visible = true;
            }
        }



        private void menu(int num, string category)
        {
            fruit1.Visible = false;
            dairyProduct1.Visible = false;
            beverage1.Visible = false;
            Meat1.Visible = false;
            vegetable1.Visible = false;
            lblWelcome.Text = category + " category";
            lblWelcome.Location = new Point(400, lblWelcome.Location.Y);
            switch (num)
            {
                case 0:
                    lblWelcome.Text = category;
                    break;
                case 1:
                    fruit1.Visible = true;
                    break;
                case 2:
                    dairyProduct1.Visible = true;
                    break;
                case 3:
                    beverage1.Visible = true;
                    break;
                case 4:
                    Meat1.Visible = true;
                    break;
                case 5:
                    vegetable1.Visible = true;
                    break;

            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            menu(0, "Home");
            EnabledAndVisible(false);
            picturegif3.Visible = true;
        }
        private void btnVegetable_Click(object sender, EventArgs e)
        {
            menu(5, "Vegetable");
            EnabledAndVisible(false);
            ProductsManager temp = vegetable1.P;
            manager.mergeProducts(temp);
        }

        private void btnMeat_Click(object sender, EventArgs e)
        {
            menu(4, "Meat");
            EnabledAndVisible(false);
            ProductsManager temp = Meat1.P;
            manager.mergeProducts(temp);
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            menu(3, "Beverage");
            EnabledAndVisible(false);
            ProductsManager temp = beverage1.P;
            manager.mergeProducts(temp);
        }

        private void btnDairyProduct_Click(object sender, EventArgs e)
        {
            menu(2, "Dairy Product");
            EnabledAndVisible(false);
            ProductsManager temp = dairyProduct1.P;
            manager.mergeProducts(temp);
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            menu(1, "Fruit");
            EnabledAndVisible(false);
            ProductsManager temp = fruit1.P;
            manager.mergeProducts(temp);
        }

        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            EnabledAndVisible(true);
            lblWelcome.Text = "All Products";
            lblWelcome.Location = new Point(400, lblWelcome.Location.Y);
            fruit1.Visible = false;
            dairyProduct1.Visible = false;
            beverage1.Visible = false;
            Meat1.Visible = false;
            vegetable1.Visible = false;
            picturegif3.Visible = false;
            dataGridViewAllProducts.DataSource = manager.GetProducts();

        }
        private void EnabledAndVisible(bool i)
        {
            dataGridViewAllProducts.Visible = i;
            dataGridViewAllProducts.Enabled = i;
            pictureBoxProducts.Visible = i;
            pictureBox.Enabled = i;
            comboBoxProducts.Visible = i;
            comboBoxProducts.Enabled = i;
            lblrandom.Visible = i;
            lblrandom.Enabled = i;
        }
        private void InitializeProductImages()
        {
            productImages = new Dictionary<string, List<string>>()
            {
                { "Cola", new List<string> {
                    "https://meat-night.co.il/wp-content/uploads/FIL_6234678_636939469931273949.jpg",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTEAhbAm_gWUJ5NrRHgLHWoFmVtiJiXA007_g&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTPOf5i8UmShfwJ9xr7vKowGD0xg6pZLuhc0A&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR4TsBtL8ahnWXkzgt9aPHmH5bzpeGQDlyIWQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRaShIrlLjx8D9jdE-HS9vQ6M4jMNCAX19GhA&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRQsDimZio1M6Wa66I2UoHe2ubeMleyftPSe545agvrIANhDSD5gzt43V43X0u4T52EQQM&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQpzmLaKbO3UINAkP8V9Yr724WvTnBYCUtNrg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-tY7S_yItlui5603PTKzLhwGDFzsGuEfnnA&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReZ0DeKtnMXZdRlpL2eQ_Cniely6scnRc0H7obZGjgwBG48L5-DtpW5T2ztdyB4MECl6Q&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTb4Bj5KVfoRRJZTJ8CfV7sS-qM8geaxs56WQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcREFYHk--bdPSpHBGiTVsbmbH6Onl9yo1T4VA&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSUNWI9--gx5z2WiYL7Y-gp2fANY2cXDpCXgQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRY-xyKhfPw7LIYVjU31D6PUomMTIz8uw21Qw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT6856JnO1b5ZOGRhRonr2Z7cGxO0nyPAbf2w&usqp=CAU"

                    }},
                 { "EnergyDrink", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJurkCpXjMi-hzBQpR8Dpjy8vyTAN0KX2Thw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiH8EunamRlhMQ-eI-UBU1ermxmj6SBp8DLg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSKjBqoIqqBykRHLUY64Cl8a7_x5NW1tbfA0Q&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJi8ETEoHq0rrk3XpWx1Ah-Xc_dMQhqJFONA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQA6x6zUHwJdWZ90MniNv9V7LI54_2K5Gvo2g&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqFcAieOK37H0iJmHhofiBvtoDttKmBEyr2w&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqFcAieOK37H0iJmHhofiBvtoDttKmBEyr2w&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSCgXZrj29kek9Bw3SCZazNpgMwVgL2DUdUpg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSL5Rwsm782WE3vqBbNkKidiKNmfTYHLaqHLg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGo_-RQgqyYNM9iiOE5ecr_tqmnxi5RylGTg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRAJAkAaGqQxPEpKtO5pZRKRX1vLEP6JCVyHA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR7rVhnbgHFOZha40oQ6wGYaZv1bfPiCjOAIRex_BosSB0ZO5OPfJSCp9qv2L-c9tRnR2I&usqp=CAU"
                 }

                },
                { "FruitPunch", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS-BZIk7NM44twvKzhSSldXxKfJPK1tCLUtuA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGQJ5TWGy3rds7t8OIMENbDURvFj2V0LbDag&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQg9w9UZ7Hhj0SqXKUjHFr3GXwhD_objLYRzg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ0fpY7Q6aNIFGoEvIAeWLvFIvW3C_cpif65w&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRpbqVVfhvhxLZpu790S_YI2WgkkWPiYnLinQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT4oIp4qXXrshobSvpUF3gQgr7WZVKB4lfr02QfZS1oVHB0SFRHnUAQsVeFbm00G4yS_2A&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGUbUoZis2dY0SDFXAVn9BifMx1vzaXrIlKDxeXTxJrVt1E1JcgMITs4UF4lHwZYm_eZk&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTz0QZX80M6lwQMD5Apx967R5l09K2qtu_3TQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdTUEaP7-_6goh4nSwEO3xlR135ODI_vGqbw&usqp=CAU",
                      "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSShhqUiigJvXdiJBmfWxzudetgbvDNEJ4-dcL0augb4HZ7NLFWE3QzfefkYVec9aXP9_Q&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYsOYWQjwrA5mTjZC_lDyEoTRIT0RCh41fSg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKNwiiSaBmJafF8YsqQu04XVPtnjNBRtK41A&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQSnRp9r68UXeUdD2BDJUUE5dX6PdBNfd-nsw&usqp=CAU"
                 }

                },
                 { "Milk", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQbIbihECI-uTy6G7f9un1O6t89W42fkPTNWg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSiZguIH5h4glcyBcUWSHrXF-FL7Uv5TkwA-g&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvzIPgV19sWfBK2wtY18VbHWc7BSgUOk0Q5g&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1AhajSWIvNIl0BZ9uZPEfrqOIv6zv_QNjkQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSPyZaKfydMBA_gh-iwupak6CYl6e8e7haLvg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQgDGMGPPXmuK9IudOiWqb7nIyiWWteZDdQMQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRr23sO-4DiR6vjY_6UzWQGa2CFJnuq4K6bgw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTSoHlncMvZLXDsyThPPzm9OpWZsmx_ZAD3-Q&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRcoWTGdp5AL_xR1RqDzMrnCKebe_1XZdXj-fLVYW_UaaSnOsuxSuQklrDp7mKdmhBbKe8&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2OCsitrHkxs1Ep2YL3AEBrvEvvtqZ3c66Tw&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQBxC7s-xtoUi4dcxdL-hqyApsOmnDH1uwrBA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQRjVLzrrWzX2b2IIwBrXKbko9_R_wZoRwkyg&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGolYaMoN_rA5BZYXhMH0BHFF-wklLCQlwZQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWoROLphqyMA81e5Xc2x9r743xbmbt5dOOdg&usqp=CAU"
                 }
                },
                 { "Chocolate", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_q3RgbT5l5mBlVr4thFsw_wfe6ZPSDuTm1g&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWVM74QV4nil-tftlGtoMvXwcIfoVxLAUYoA&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTk_ksrXl8wq612mJrQwfbMjAzFgYg89VSNZA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1XcB6s5bm2bh9zANoZCdP6WwXy2yC9U4HRw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ-uQg425fa2pWj55oW27SQI4WBzfm5O9Thxw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBWBfaHGqMJJ_-kX2EHNccEHw8W8TA9s-TTw&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSccNlR07yy9ksD64npSAqL7ejjD82ohiZDyw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRuvA8PX8x7dNa2W5K8z7BIzCPWzh_LSfgzyg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTcZaBJK2JW0DF1oEMgSUq02pnCJn9sPs-XBw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_4WVntIOBgprpHYTixQXsBxbEYPNlWH9vJw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQSXKdUXIWl_yJhclFPDz5cQQVw-zpILqayYA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYOQ3XGUECQsPbZlQk-l0cF9mrFcjhDsNfQA&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9yb0KdbWU0PcU2z6Ux6ywhhqksNNZCqzhPQ&usqp=CAU",
                 }
                },
                  { "Coffee", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSDGOQzcZ6sxcRSsoVDRtpvMCVpeiF3ad_OUA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQwwGDnxmEcBgdtswsv60L7jVThslXktCgeUQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSPf8-u0Ns6ZujSIiiYqVxwUUtqWX261125-Q&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSe9CvHESeZITeP6-1fFNqKPREPtGd16Zt_quJExABbYM0mpn5foiejHAKsGVL_aKJgUg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGOeMZqrXDogHX4OURAVpwZFNf1VqyXkBb3w&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSEWBhlCNBHdjZ_ry_HbqhCTnMRX_EoZYjqfA&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTd7UyMxVvbyiLwy7J7U3MPpEyGPT16IobnA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT85qCso14wbbkKz2np01S-qfMEyt7WX8Zxtw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRogaZSA45yIS9lrJCbFgfaGukpFYN3V4Vtmw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTYhXrL0G6I7VfYEzJAMcQTl2oWob5O0Gja8A&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS4cPqTy2OH37N1xqJ7m80H1lf09XAulb_d-A&usqp=CAU"
                 }
                },
                   { "Butter", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRuycIDivFKrV4Jmx-7lp5w29SwsWh2j6Vh4w&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRbu6bKq1Hk9MfV73dPUbcUfBriT09w3zknsQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqEyrJwtmKX8ksHFCjE2bJMvrkf0p6L4oRZQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSFFbUz8ksw9jODgAE7wqtDK9edMeU4d-DgMA&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSpxKyqY1HgV2OXsdKmWyTnkgDUahL3l7L6KA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTuOhfZd_8vZbO1mB1JZrVFCZFkm5-Is4MUZX94Bx8Pb-dtH_Upq9uOSkq3DOccQdTtJbI&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTpPWrGCivdQBXLITDOwcnqTWJd_lGhzvhQPw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGMWg1Z6xRKZfFXRbE-a7e80_vyyPyYeTmxA&usqp=CAU"
                 }
                },
                    { "Yogurt", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgF6X5YpWCVg-u-0oL4-1lTIlYkfLqh_hT9w&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ_0WZKphHaheOMvs3pKZ_zQLeC-Btlw2tK-w&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRzVUZv28iOHLl4sZwX4P0ho4q-iXMZ0pawIw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS9tBCFrOb3SE7vNo-tF7HXiGWs6Pqx83eDSQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRxj36x04AdyWEyEhyZJosPSQ0VEWeIWtQazQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTh6rLRMtZ9oRSqeSqER755MVmScMrnvfdF3w&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQDAo6luFYw1nZdGOp8h_FUdmbmREh9hgtd_w&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQW8dXSfElzb-mfVyhMyNtIYEZzfEWa8pMUNw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtw8p7W1zMKATvDFcjSXpjk7ecKb35eL41rw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTOGnv8xsn08-bVGd8cE6XzCrGHsvKE1ZlQ6_qMd0TDlFJQdQwWk9fYOIub4DCD1qaqF2E&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGn2uePLoLYlwRon-hpfmSzCLMNJErpC_g97Xl20rLvkJvykfS57K0hT4vf4wOjdUzhNI&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdqh-0EEHOuWKfHlMx93J9Rv1LzEgSho1qslniU7ZJAwLgIzu94FXZnr_pjSgR_OH0Ttw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSPgz0SUlhGjouSMeC9NWPa1-Gl30XfR0iDOw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSR7pb_ggp5di2QJWh1p4IpFwADu9G6vUXkaQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8I4g3dGrL7dpTt9gaZJK6nTkSuOLlyvqj8g&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSHRDPcRkOnbTM3FgbCmXdJKLCqorx57QpIxg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ2IDzJGi7XzWxeNiOeyja8Ueqy3r1mdTJyyQ&usqp=CAU"
                 }
                },
                     { "Cottage", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKj_ri_ZH6r1DVqN6QLK09Qq14xbKwEYTFCA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRn4VVdr6H-YtvNI2K4AAEhPWDr8G--7PKjcQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZQ83R4LNRWFMWIhCj4Tp_ZBUV34yn2im_7w&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQMMlPyUVvptq2Vf4i2dAzlXZuheTwJJpOL6w&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ_hzMLRHGvk3rX8EO_LS67KR_NEOExBzVIWQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHwph_9de0f-uJ4Urn9AwZS-nd8IOoMupRkg&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQBopQ2hOBXQkq_EXNbs7IsiCXPor8PDKzMUQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSt616seJLWA8HH23gD79cbwUhEpfuFI-nRKg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRUGLvNdq6IUl_tsZwUvGxk9IUh-0Xi4lILUw&usqp=CAU",
                 }
                },
                      { "Labneh", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBOS4A5GqwwkVpU6Vgl78NnrfMS48FIhKxIA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdVeqMVje6Lg5XFdVqeKnJ5b1XCRnaIaF74A&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg3P7Q26zAMJoUuB1OxwWRn1I1cC7CJsOwiQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ_VEZ0z12Anr-pc30wGDVyU1HYA3IRxP8pWQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbRbqGBrZHsDRXSQYoT2Uc7avWhghkvE0VAg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS6qalS8URrqCeLOlp92HWx4i3Cq3RdR0HjmQ&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS-mY_69T5Gm9azLeFb61AHkWgYlIFa2RSFbg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmWhP5lsMgpS4rNpAoqcDU9q37PIo0mNgtMOc66TSc0Bj2oTMQD6AorVXrwtUn9D0v1e0&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQT8NjJPKTuO_1skAL5GhlNEaWq-PjwbPB8qg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTlWihAY8WCtK6kljtRx6jmsq86FwdJXOjpdQ&usqp=CAU"
                    
                 }
                },
                       { "Mozzarella", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSKc1hlQVZ5jDGH22w0Kn5atrDi95EkGYrGVw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS4DHZA1KwR-3oCXa5eEhm74T1t5f1MzZ2-Aw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZqjwoIIiOHkmW4A0-By-9vGTao1J1Jmw_zw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRcATHN-C_czA1VkRwWW651eYcpFlwco2dwXg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcStlxp3O9lzoZRmrtiCmrxdCLXGltJzunkqBg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRcFwb_lQ0iO5-SLM4gknhueFA9s5XNbkOnYw&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSHqCvCEnTZtgrCjFoS6GAmIDNItfBZMTQtyA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTPoafeK_UgCWWhoPbqURrPFHneIz8C9210AA&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThmJxVSCUKr88u-W2Iy6Ul9L_8fHeQyGfqxA&usqp=CAU"
                 }
                },
                        { "BlueCheese", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxPGaCRqNWWE1vptuTRvY_TModK5ew6t0VWQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTcC7JbNcSmXdUE5yoAzckj2IAnkP8qUjf_Tg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWaSEK2gxJtSDjLJn5HdciIMEz6HC6OSMraA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQlXE3EP8hCEBftr1-NlCvTQ3zONu4lG9T6uQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwgEETU_wkDVZM71hEsMo6N68Vj9GSYWa92A&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS6fChESVXi5uTzHS0usDgt24sW9YEAk3kZrg&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTh5TNvZTrNZ8w6AH9wqYgaNE2Ak27GHSIdyQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnj_JIJr_n8O4miX9BL0eCvBw2s4qW-sSSdg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT049enxo1rWTy6D6x0pBK7FGyn66dYVywLLg&usqp=CAU"
                        }
                },
                         { "Beef", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTCqomogoFOGn9kXMu-7H6m1qnvk2Y0muzA5Q&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhUGod3ftJSHSnF8MqPPMAwepam-Y3XZTfOQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtjMKv3V_Il4NWFrH8TXzojNH321iaxuC-sQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQwUAYGzxdDjJXbuMT2wYRBpIVvd5EONJdzDg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQuV0EpdbcbrHAV6XSDmhbuqX7L6_dVMWjLuAIynXTxXe8LDMjxP-LgqsVv7C8EKuitOo0&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOo_aRjW9x0PyBtshIWcsBPKwPITdzft9lQA&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJmSdXDcZlZ2Iwm3cUX7rm5_hvx4XtJZG62A&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTCqomogoFOGn9kXMu-7H6m1qnvk2Y0muzA5Q&usqp=CAU"
                         }
                },
                          { "Pork", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxvI3BKPUs_zSZlGyCgscHLxM7PYNyLEx7bQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTb9RM4yt06bapWIafMR2VeqylZ0VyUJzLJcg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSfuLVIPItdNDR2iI6jMqTG5T4cAltQyIQngw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT--tfuS2vDQOgi-GK2YhBSNmxXwLHHMBeElQ-SCKxiO9diSbqyVPkqHKD7jD26TKqrWGM&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5j3TR91S0dEwe5a7ukL7A2_Drd4-FfFANpw&usqp=CAU"
                         }
                },

                           { "Lamb", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRE8Hj57jPxK9K8SckqEcA36CjPWdUA-7MRg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSeojrqbncracP06Up1Fq03xpKoaC0oHJG30w&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTRXQUBbye58ZJyWLPb2AAnh1_VuQorop-ZZw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSuwPJGpLvXKp_rD42RKj1jXYXNGzatHHz3sQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTQsGU-0Lst79xLsiC2evNrA35na_ggo4TPTw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSFMlCIdZEMcZ1wmzm4gCW-hV_SKK9iBP92zg&usqp=CAU"
                         }
                },
                            { "Chicken", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQMM-t-2fp4szmCwAlXCQFC4cmJiEIQ8yws0Q&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSIWc8FAnAUBU99dCsg1Fr-8twu3q76eStXkg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdOpAxAfyAyj6EmjY0eHhs6MSvpWdgjpJ3ow&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTzh6t93JGx2YOF43fi4hZlCFovovOxTU9qMQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT2gmjolWRBJJGxOrGmrZuLYuYHDpACkV0E6g&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQIkl5WmyBVNWhlhWrqR2lIcPvAQvr1ZS7-Jg&usqp=CAU"
                         }
                },


                            { "Tomato", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT0DBuyR7N0hTpQfKuAGxNveT-B4x4R-zvKsg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ4iWljWoaK4rrHiJ-ZcnBEneuN12ixYpH4xw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNIY9W5DxVGXTtV4gR1ZU5qipQsRkpK2pZ3Q&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSJspcvKxOdTerkWdaVvF5PR90BptkBvmr-WQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT31ywOgFMjDiEX_zBzuNgkSeMHY-lu5olaHw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFUFk1MLTQf_F1p3TY-CT1bEuYSCPafMMU2g&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSNQ6FBY1H1vaU9QTpQt4HmBfyK1uaR7DrBgA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRKh7vtWlCWnsquyxG7FrkG25ci0JXGRva4Ag&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSw14vCDS5NOS1W6eij-7x5CkTjd4eZ96Jsug&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSj_i06VduBsww-JQpNq0WOgv-i_B5mlkc6tXrjLG23O4tMffG9_KmdykZt7LImfFVTQg0&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSrigRno4ctV9Rw9sQxewWVTCXfiNpbc2fv2w&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRVR1AsMVhSk-kUiPeLYJs-kxPajJI0a0j0tQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQhSSLsB9ymRfHqEcyaxhag7jHPQq3dWjtJTA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTidAgElqGhhU_d5t79gBaplk2d1Li0I1al-Q&usqp=CAU"
                         }
                },

                             { "Cucumber", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmgt7ud8wjkdeJpsBTZ0gAP81pjGCRiFY8-H8Wt--PDLmUSVo6XFC-6E9lsY7ngk5ML0U&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQJiLDH7aWjFJcWhJd1ZInP9pxSYlm5rG6sA&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQhRuCVAB4TG8KsXhZrnfCgwMSdw5QN8HTcXHjg2_ZxLCpSw3fbIhGoHUsQDPnsfI3iQnA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRK2g6SumipKt98gVjiRlJQySUm5iLa6aEh0w&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbabfiVUWb2clCX7OQxAbs44s1zLHQRQ9YHQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRAMQuQNwPtyseaiPRHgqpgDnVBBcoHAkAKNQ&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRAMQuQNwPtyseaiPRHgqpgDnVBBcoHAkAKNQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZf4rcv6JJ30fMuDcbu0Ta9yCcor8ABLQu_Q&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8nDfMYcnvOAQS-6WbdA8-qE3PDFZZnxBuGA&usqp=CAU"
                         }
                },
                              { "Pepper", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSeMaBSp0BTlvkgl4quWAD6rjqBuLNSrkbqgw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSb9FGYD3HnCaqLwhbzuHNZm7VmhJ-8mxXC_Q&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSAqywuXT80S7oEpYVbEO5r5mjxWBsTyDV7JQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWZ1USdOwWnIHLg6wqCeLMg2mLbQrMsfGbXg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRh9FcTYl3r7ZFehV0ceH89CRY_hyrGyT0RQA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRaBZGgAiyN-4voOrsRlGkKPn7M9QYPN2TzFg&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTDiCSf3wgMqogaNFjgh9mfGdGnm-rB8OKBbQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5p2OkHcaBOKpFLAl9Y4NJ7jzOF7oZUGZEYA&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTe8vwrjaMS9ACrgH3q2XIJa7RA-mw2A8X5jA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9wKl5ntdodBdw2U5h1yf-44jK3sgvKMx5d8dlkC6ECZaLOubQVDOPQanVHQJUmIKQ6B8&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQbHjjmr-3gIo7RySmCw6MyVU9bZ87MXMHZOA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRP8kDJcfw6UZhd8PNnve6UGrTvIArivdKILg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRfrbrBHYaA-_WUjWLKWaQCGHTaNW3EknNEg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTcLJOzWyDkqVSJpmxWxRESYMQYl-5Dq4M_7Q&usqp=CAU"
                         }
                },

                               { "Lettuce", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR5r4sXC-0hStgQ-toE6D7vhm50bThvsVz9tA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRiB8BYJc-gkjonEl16a0iw-c4qcb4Bku1dnw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTzmxJnFWHH0fNq5-VnxtS6Q6b2COw4q-gGOg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQKBhwvzlciCI1C1zrd6S5kseR8WIEj8F4gM0E2r9TiwQJBSBl3YYwD81H17jU_Q31Eejs&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTnpC9hXbgfl5Fynsbwoz-sCsQtJ1aYblLKwA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTnpC9hXbgfl5Fynsbwoz-sCsQtJ1aYblLKwA&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl_4IGFHtHM2t4T7eWU4uTtJf37r_vuv0N1w&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYmfcWU8WXChanhzD0E0t_qj76UmVBCthcOg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRcmTXDtgccAm6jAaMLTdKm9_gaTl68WQ_SPA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQpuGyFSxWuDiUWcxLJSKD_bvuhcaQEP4Y-1Q&usqp=CAU"
                         }
                },

                                { "Carrot", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdPqWZgrakPnBDbVGiw6-l668SR89FXqSLPQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTHyDRQM1Muqvsk8OAsvj3ThBfEJJlB3TskEg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_ik5Nbphu0X7Js_jDw7CtwgBBZnnC3_zZHg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReVVshkMYh3mvBy9umAKAYuUTVX0VTHYUMKw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSvQJrwE-fhPeTPKJihYqtfRFAeqPi3EV5teg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvGD1TvfHX1TbjBY8qMZxSs9obvd8SD7drvA&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRgHYS--2wTB96M83rUEV0CoNHnBRSN8RFHeQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBiIyvfTeuMnaKTh_j8XVGL7M3NAUs2YvmsQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQhZSGVb7CShRjy90e_u4xyqRPeamx5mLV31A&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRXv0otG-lyy4OkvgvjIjOZgJHnoVMs4isZ4g&usqp=CAU"
                         }
                },

                                 { "Apple", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyzkFkSal5732ozrr6T40PDSbDr_F59p8Dvw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSi6t8fD2HwZkq6IwWEda9lE6GDSogdJl4h9A&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ868djAR5mIlAFnnjF---4paarCg48aQTr-g&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQFbf2RGhyYEHBQLmmDFUJknhQl7mDz-DTq0_danxDo5yT1MyBK0QbJQ1A353zgaiLtoyo&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5ffZfOL8ck9ve3c1mVUz7f7VKCMoeqsslWQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9q3sBCEt92D7dO7aMTJObGu7QoyaeE_54tA&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR03yNVQU_Hsvm_CWsfz1ie2k1N7hIJXEuUDg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_lOBgg8K1gWfPfbArXXBy6j9IY0_axbfk-A&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTvaKS3MaNqMQbA-2VS-c6X09KDKEsbH_jmg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTljOLfUzVgdq7T41upxcohOyj_haRrLWCvtg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSL3q7obYQnVgwPJtOjG1B-RRNEOabjQKZ-kA&usqp=CAUhttps://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSL3q7obYQnVgwPJtOjG1B-RRNEOabjQKZ-kA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRLu9DLcGr89NNlxB2tiIkuscxQz4_O0LheSg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR9wsG-68QfkOkIR7Ysa_CFmpjBx1LbksAx1g&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxIOItqrVnrBNPzQYeNXX4JnKn52ODTbfZXQ&usqp=CAU"
                         }
                },

                                  { "Banana", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdbljUY25LnqfU2lnikAaqLEX3loQw7Rv72g&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRo4rgJNR2RqWzM05z4JywkwoEgO63mskHEZWf8vhne1emWrMC0mvLBftA1otcxaSldBRU&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSIiid-2374TyaJrdIfcf3Av7qtdZIlmDDtZw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSgRMmGjQ5d7yON7bqVI2oC1aSSvc8k2ZUuw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-WabsHIApLHhPsuuJ4VJPWhXW9xUke5C8Yg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQmYYJCG05gqUJq7kN6uxc64hw-9tQMYPWeGukce96TTAjL3Wm-caynOfBDJs_ayXBdvo8&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRbUHngn6jJKnqFMhSEFvbB3UK2qXpM4mfnqA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQSVFIXl8bttALr-1o3dNN7pf9orkvLx3yqpw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTU3-6a7vpljPghp8bbfTcACtDTD5Gqt4RH-w&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQKD-TW8bmknS3nZCfHhsGh3-FtuIMJmuAqqQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT17dr2orn5zDVPVYGHhQScc_Pxm6VUu8Trww&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSKbgdHetbQsTydOxUSRoeBwh_vrRF05GVhkw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSyCKAxWhI8bPK55YQ_dqH0P_co2TsPDIgyeQ&usqp=CAU"
                         }
                },

                                   { "Grapes", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRj6uecyMGsD75jxvqpA9WzNJujxFjpV0xTOo5HUUpeskee7sJePkikiG6MXgTNZ9yFlew&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBwBQFXSrUiASbPnjLTt4-F8Q8f5lA5InSdg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRkhyjb2Ou4DlVWbzi5cbCosnwaepzx1UnPGw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRjT-J4hVoo8EfO_s5QauWDFW5QqXAza7NKrA&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRjT-J4hVoo8EfO_s5QauWDFW5QqXAza7NKrA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSc2reG9aiMv954IXUve3uDgBYTf5OkxMOU0w&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbD_zxAwWeMYTQjMKizlzdBIoVFdm6_FauNA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcREjoMedh7-cwNv1mi1z53s5E-t-u2Qaz9arQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ31WCpIOl7_rr4H9ZO-7WPSmAOrM7hs7w-uA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRs91jk3NAsBFz_BuIq0LUmSjfB-wi6EqMxPw&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmMTGbtpXJlZXepni-BSNufUHXjc0oznz81A&usqp=CAUhttps://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmMTGbtpXJlZXepni-BSNufUHXjc0oznz81A&usqp=CAU"
                         }
                },
                                   { "Orange", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSmqi-EX_cfuJmKokHEzsukGSniQKFFCMhPEw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSDqorIYIykzg4TUGGA5vuk2wkqsdwa-h79FA&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQu-DlUxnWvqnyn91PjE-5XmAi76joA6zAHOQ&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRaO9cE7vhrDA62ZGeg15GSXgfzMZ_iUb27_w&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoVJHaw6r3sDWp0G3ltIvjcCFejvZWjVT65CCHAGrB7oRU5BvOiSzzNb3pkxfQKJFG6KE&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQuF6TxljQwLSNJrE-Jy_AGzCPnIU652odEdQo7tK-g-ofcJ9rQ0al-gbS5LRsnAmfyEZY&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRCvfIFD4YtcJD6rUDaQy6z4f9s1CgrUeRuPg&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSNL-uezwFGB0B2bLf_IWsj4awTtpPBrnMZaw&usqp=CAU"
                         }
                },

                                   { "Peach", new List<string> {
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAA92-EzVmd8Pif2cHJBWEZo-cX-xvPpAZdA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYqCSnTGSDew-nKj6fNoi8habyGINqrVOz0w&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ97z0dYW7YxKmOezznexEUznVtIQvCAGm8Yw&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTpAyZt0dr9_ec9y8i9JUJctdsv_oBpVD5xeQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRud37irr2RdOSdDXguFNNSjqOc_Mbkub2cjA&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRud37irr2RdOSdDXguFNNSjqOc_Mbkub2cjA&usqp=CAU",
                   "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTFlPKE2KPY4EgtOWz72-Bt3xw8U9odWn-3Ng&usqp=CAU",
                     "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsh_mZkFZpa685fsFD8g3vD32K7kIuhdEEeg&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRKqoKfD9b4tMOCxyDQaJD0Zo3En-bdVS_DIg&usqp=CAU"
                                                                 }
                }
            };
        }
    
        private async void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = comboBoxProducts.SelectedItem.ToString();
            if (productImages.ContainsKey(selectedProduct))
            {
                List<string> images = productImages[selectedProduct];
                Image randomImage = await GetRandomProductImage(images);
                pictureBoxProducts.Image = randomImage;
            }
        }


        private async Task<Image> GetRandomProductImage(List<string> productImages)
        {
            Random random = new Random();
            int index = random.Next(0, productImages.Count);
            string imageUrl = productImages[index];

            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                byte[] imageData = await webClient.DownloadDataTaskAsync(imageUrl);
                using (var memoryStream = new System.IO.MemoryStream(imageData))
                {
                    return Image.FromStream(memoryStream);
                }
            }
        }
    }
}