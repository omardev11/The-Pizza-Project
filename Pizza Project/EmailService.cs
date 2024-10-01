using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pizza_Project.Form1;

namespace Pizza_Project
{
    public partial class EmailService : Form
    {
        public EmailService()
        {
            InitializeComponent();
        }

        public void SendEmailddd(object sender, OrderDetailArg e)
        {

        }

        private static string OrderName { get; set; }
        private static double OrderPrice { get; set; }
        private static string ClientEmail { get; set; }
        private static string ClientName { get; set; }

        public static class ProvidingEmailService
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

        public  void SendingEmail()
        {
            //this.Show();

            txtTitle.Text = $"Hello Mr {ClientName} We Received Your Order And We Send The Information To The Restarunt So They Can Prepare Your Order  Thank you";

            lblOrderName.Text = OrderName;
            lblClientEmail.Text = ClientEmail;
            lblOrderPrice.Text = OrderPrice.ToString() +"$";
            RestaruntService restaruntService = new RestaruntService();

            restaruntService.Show();
        }
        private void EmailService_Load(object sender, OrderDetailArg e)
        {

        }

        private void EmailService_Load(object sender, EventArgs e)
        {
            SendingEmail();
        }
    }
}
