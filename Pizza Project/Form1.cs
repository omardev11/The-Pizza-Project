using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        OrderPizza GlobalorderPizza = new OrderPizza();

        static Stack<string> Stoppings = new Stack<string>();
        static float ToTalPizza = 1;
      
        public Form1()
        {
            InitializeComponent();
        }

        public class OrderDetailArg : EventArgs
        {
            public string OrderName { get; set; }
            public double OrderPrice { get; set; }
            public string ClientEmail { get; set; }
            public string ClientName { get; set; }

            public OrderDetailArg(string ordername, double orderprice, string clientemial, string clientName)
            {
                OrderName = ordername;
                OrderPrice = orderprice;
                ClientEmail = clientemial;
                ClientName = clientName;
            }
        }

        public class OrderPizza
        {
            public event EventHandler<OrderDetailArg> OnOrderingPizza;
          

            public void OrderAnewPizza(string ordername , string clientEmail,double orderPrice,string ClientName)
            {
                OnOrderingOrder(new OrderDetailArg(ordername, orderPrice,clientEmail,ClientName));
            }

            protected void OnOrderingOrder(OrderDetailArg e)
            {
                if (OnOrderingPizza != null)
                    OnOrderingPizza(this, e);
            }
        }


        float GetSellectedSizePrice()
        {
            if (rdbLarge.Checked)
                return Convert.ToSingle(rdbLarge.Tag);
            if (rdbMedium.Checked)
                return Convert.ToSingle((rdbMedium.Tag));
            else
                return Convert.ToSingle(((rdbSmall.Tag)));

        }
        float GetSellectedCrustPrice()
        {
            if (rdbThink.Checked)
                return Convert.ToSingle(rdbThink.Tag);
            else 
                return Convert.ToSingle(rdbThinCrust.Tag);
        }

        float GetSellectedToppingPrice()
        {
            float Total = 0;
            if (chkExtraChees.Checked)
                Total += Convert.ToSingle(chkExtraChees.Tag);
            if (chkOnion.Checked)
                Total += Convert.ToSingle(chkOnion.Tag);
            if (chkMushroom.Checked)
                Total += Convert.ToSingle(chkMushroom.Tag);
            if (chkOlives.Checked)
                Total += Convert.ToSingle(chkOlives.Tag);
            if (chkGreenPappers.Checked)
                Total += Convert.ToSingle(chkGreenPappers.Tag);
            if (chkTomatoes.Checked)
                Total += Convert.ToSingle(chkTomatoes.Tag);
            return Total;
        }
        float CalculateTotalPrice()
        {
            return ToTalPizza * (GetSellectedSizePrice() + GetSellectedCrustPrice() + GetSellectedToppingPrice());

        }
        void UpdateToatlPrice()
        {
            lblTotalPriceEdit.Text = "$" + CalculateTotalPrice().ToString();
        }
        void UpdateSize()
        {
            UpdateToatlPrice();
            if (rdbLarge.Checked == true) 
            {
                lblSizeEdit.Text = "Large";
                return;
            }
            if (rdbMedium.Checked == true)
            {
                lblSizeEdit.Text = "Medium";
                return;

            }
            if (rdbSmall.Checked == true)
            {
                lblSizeEdit.Text = "Small";
                return;

            }
        }

        void UpdateCrustType()
        {
            UpdateToatlPrice();
            if (rdbThinCrust.Checked)
                lblCuresttypeChange.Text = "Thin Crust";
            if (rdbThinCrust.Checked)
                lblCuresttypeChange.Text = "Think Crust";
        }

        void UpdateToppings()
        {
            UpdateToatlPrice();
            string TotalTopping = "";
            string Seprate = ", ";
            if (lblToppingsEdit.Text == "No Toppings")
                lblToppingsEdit.Text = TotalTopping;
            if (chkExtraChees.Checked)
                TotalTopping += chkExtraChees.Text + Seprate;
            if (chkOnion.Checked)
                TotalTopping += chkOnion.Text + Seprate;
            if (chkMushroom.Checked)
                TotalTopping += chkMushroom.Text + Seprate;
            if (chkOlives.Checked)
                TotalTopping += chkOlives.Text + Seprate;
            if (chkGreenPappers.Checked)
                TotalTopping += chkGreenPappers.Text + Seprate;
            if (chkTomatoes.Checked)
                TotalTopping += chkTomatoes.Text;
            if (TotalTopping == "")
                TotalTopping = "No Toppings";
            lblToppingsEdit.Text = TotalTopping;
        }

      
       
        

        private void rdbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rdbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();


        }

        private void rdbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();        
        }

        private void rdbThink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rdbEatin_CheckedChanged(object sender, EventArgs e)
        {
            lblWheretoEatEdit.Text = "Eat in";
        }

        private void rdbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lblWheretoEatEdit.Text = "Take Out";

        }

      
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Conform Order","Conform",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gbToppings.Enabled = false;
                gbSize.Enabled = false;
                grbWhereToEat.Enabled = false;
                grbCrustType.Enabled = false;
                btnOrderPizza.Enabled = false;

                GlobalorderPizza.OrderAnewPizza("Pizza", GlobalSetting.Email, Convert.ToDouble(CalculateTotalPrice()), GlobalSetting.Name);
                EmailService emailService = new EmailService();
                //RestaruntService restaruntService = new RestaruntService();
                //CargoService cargoService = new CargoService(); 

                emailService.Show();
                //restaruntService.Show();
                //cargoService.Show();

                

            }
            numericUpDown1.Enabled = false;
               
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPappers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkExtraChees_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkMushroom_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbToppings.Enabled = true;
            gbSize.Enabled = true;
            grbWhereToEat.Enabled = true;
            grbCrustType.Enabled = true;
            btnOrderPizza.Enabled = true;

            //reset radio button
            rdbMedium.Checked = true;
            rdbThinCrust.Checked = true;
            rdbEatin.Checked = true;

            //reset Toppings
            lblToppingsEdit.Text = "No Toppings";
            chkExtraChees.Checked = false; 
            chkMushroom.Checked = false; 
            chkOlives.Checked = false;
            chkGreenPappers.Checked = false;
            chkTomatoes.Checked = false;
            chkOnion.Checked = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ToTalPizza = 0;
            ToTalPizza += (float)numericUpDown1.Value;
            UpdateToatlPrice();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EmailService.ProvidingEmailService.Subscribe(GlobalorderPizza);
            RestaruntService.REstarungServiceGivingInfoToClient.Subscribe(GlobalorderPizza);
            CargoService.CargoServicesGivingInfoToClient.Subscribe(GlobalorderPizza);

        }
    }
}
