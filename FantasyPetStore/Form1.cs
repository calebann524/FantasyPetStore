using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyPetStore
{
    public partial class Form1 : Form
    {
        const double DRAGON_PRICE = 242.6;
        const double HYDRA_PRICE = 137.7;
        const double GRIFFON_PRICE = 27.3;
        int dragonAmount = 0;
        int hydraAmount = 0;
        int griffonAmount = 0;
        double costBeforeTax = 0;
        
        private double costAfterTax;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            dragonAmount = Convert.ToInt16(DragonFeedInput.Text);
            hydraAmount = Convert.ToInt16(hydraPolishInput.Text);
            griffonAmount = Convert.ToInt16(griffonPelletInput.Text);
           

            costBeforeTax = DRAGON_PRICE * dragonAmount + HYDRA_PRICE * hydraAmount + GRIFFON_PRICE * griffonAmount;

            totalCostLabel.Text = "Your Total is:   " + costBeforeTax;

            costAfterTax = costBeforeTax * 0.13;
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            double total = costBeforeTax + costAfterTax;
            receiptLabel.Text = "You have bought \n\n" + DragonFeedInput.Text + " Dragon Feed \n\n" + hydraPolishInput.Text + " Hydra Polish \n\n" + griffonPelletInput.Text + " Griffon Pellets \n\n Your tax is " + costAfterTax + "\n\n and your total is" + total;

           

            
        }
    }
}
