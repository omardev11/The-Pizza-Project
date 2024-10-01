using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pizza_Project.Form1;

namespace Pizza_Project
{
    public partial class RestaruntService : Form
    {
        public RestaruntService()
        {
            InitializeComponent();
        }

        private static string OrderName { get; set; }
        private static double OrderPrice { get; set; }
        private static string ClientEmail { get; set; }
        private static string ClientName { get; set; }

        public static class REstarungServiceGivingInfoToClient
        {
            public static void Subscribe(OrderPizza order)
            {
                order.OnOrderingPizza += FillInformation;
            }

            public static void Unsubscribe(OrderPizza order)
            {
                order.OnOrderingPizza -= FillInformation;
            }

            public static void FillInformation(object sender, OrderDetailArg e)
            {


                OrderName = e.OrderName;
                OrderPrice = e.OrderPrice;
                ClientEmail = e.ClientEmail;
                ClientName = e.ClientName;


            }
        }

        public void GivingInfoAboutOrder()
        {
            //this.Show();

            txtTitle.Text = $"Hello Mr {ClientName} We Received Your Order And We Will Prepare in 5 Minute and Then Send To The Cargo  Thank you";

            lblOrderName.Text = OrderName;
            lblClientEmail.Text = ClientEmail;
            lblOrderPrice.Text = OrderPrice.ToString() + "$";

            CargoService cargoService = new CargoService();

            cargoService.Show();
        }

        private void RestaruntService_Load(object sender, EventArgs e)
        {
            GivingInfoAboutOrder();
        }
    }
}
