using System;
using System.Drawing;
using System.Windows.Forms;

namespace VerzosaLabActivity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeFormDefaults();
        }

        private void InitializeFormDefaults()
        {

            if (cmbFood.Items.Count > 0) cmbFood.SelectedIndex = 0;
            if (cmbDrink.Items.Count > 0) cmbDrink.SelectedIndex = 0;


            txtSubtotal.ReadOnly = true;
            txtDiscount.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtChange.ReadOnly = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (cmbFood.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a food item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDrink.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a drink item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cmbFoodQty.Text, out int foodQty) || foodQty <= 0)
            {
                MessageBox.Show("Please enter a valid food quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cmbDrinkQty.Text, out int drinkQty) || drinkQty <= 0)
            {
                MessageBox.Show("Please enter a valid drink quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPayment.Text, out decimal payment) || payment <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdoDineIn.Checked && !rdoTakeOut.Checked && !rdoDelivery.Checked)
            {
                MessageBox.Show("Please select an Order Type (Dine In, Take Out, or Delivery).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            decimal foodPrice = GetFoodPrice(cmbFood.SelectedItem.ToString());
            decimal drinkPrice = GetDrinkPrice(cmbDrink.SelectedItem.ToString());

            decimal foodTotal = foodPrice * foodQty;
            decimal drinkTotal = drinkPrice * drinkQty;
            decimal subtotal = foodTotal + drinkTotal;


            decimal additionalCharge = 0m;
            if (rdoTakeOut.Checked)
            {
                additionalCharge += 20m;
            }
            else if (rdoDelivery.Checked)
            {
                if (subtotal < 1000m)
                {
                    additionalCharge += 50m;
                }
            }


            decimal discountPercentage = 0m;

            if (subtotal >= 500m)
            {
                discountPercentage += 0.10m;
            }

            if (chkSenior.Checked)
            {
                discountPercentage += 0.20m;
            }

            decimal totalDiscount = subtotal * discountPercentage;
            decimal finalTotal = (subtotal - totalDiscount) + additionalCharge;


            if (payment < finalTotal)
            {
                MessageBox.Show("Insufficient payment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChange.Text = "Insufficient payment";
                return;
            }

            decimal change = payment - finalTotal;


            txtSubtotal.Text = $"₱{subtotal:N2}";
            txtDiscount.Text = $"₱{totalDiscount:N2}";
            txtTotal.Text = $"₱{finalTotal:N2}";
            txtChange.Text = $"₱{change:N2}";


            DisplayReceipt(cmbFood.SelectedItem.ToString(), foodQty, foodPrice, foodTotal,
                           cmbDrink.SelectedItem.ToString(), drinkQty, drinkPrice, drinkTotal,
                           subtotal, totalDiscount, additionalCharge, finalTotal, payment, change);
        }

        private decimal GetFoodPrice(string item)
        {
            switch (item)
            {
                case "Burger": return 85m;
                case "Chicken Sandwich": return 75m;
                case "Spaghetti": return 95m;
                case "French Fries": return 50m;
                default: return 0m;
            }
        }

        private decimal GetDrinkPrice(string item)
        {
            switch (item)
            {
                case "Soft Drink": return 35m;
                case "Iced Tea": return 40m;
                case "Coffee": return 45m;
                case "Bottled Water": return 25m;
                default: return 0m;
            }
        }

        private void DisplayReceipt(string food, int foodQty, decimal foodPrice, decimal foodTotal,
                                    string drink, int drinkQty, decimal drinkPrice, decimal drinkTotal,
                                    decimal subtotal, decimal discount, decimal fee, decimal total, decimal payment, decimal change)
        {
            string receipt = "================================\n" +
                             "           ABC CAFÉ             \n" +
                             "================================\n" +
                             $"{food} {foodQty} × ₱{foodPrice:N0} = ₱{foodTotal:N2}\n" +
                             $"{drink} {drinkQty} × ₱{drinkPrice:N0} = ₱{drinkTotal:N2}\n" +
                             "--------------------------------\n" +
                             $"Subtotal: ₱{subtotal:N2}\n" +
                             $"Discount: -₱{discount:N2}\n" +
                             (fee > 0 ? $"Service/Delivery Fee: ₱{fee:N2}\n" : "") +
                             "--------------------------------\n" +
                             $"TOTAL: ₱{total:N2}\n" +
                             $"Payment: ₱{payment:N2}\n" +
                             $"Change: ₱{change:N2}\n" +
                             "================================\n" +
                             "          THANK YOU!            \n" +
                             "================================";

            MessageBox.Show(receipt, "Order Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            if (cmbFood.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a food item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDrink.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a drink item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cmbFoodQty.Text, out int foodQty) || foodQty <= 0)
            {
                MessageBox.Show("Please enter a valid food quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cmbDrinkQty.Text, out int drinkQty) || drinkQty <= 0)
            {
                MessageBox.Show("Please enter a valid drink quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPayment.Text, out decimal payment) || payment <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdoDineIn.Checked && !rdoTakeOut.Checked && !rdoDelivery.Checked)
            {
                MessageBox.Show("Please select an Order Type (Dine In, Take Out, or Delivery).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Price Determination
            decimal foodPrice = GetFoodPrice(cmbFood.SelectedItem.ToString());
            decimal drinkPrice = GetDrinkPrice(cmbDrink.SelectedItem.ToString());

            decimal foodTotal = foodPrice * foodQty;
            decimal drinkTotal = drinkPrice * drinkQty;
            decimal subtotal = foodTotal + drinkTotal;

            // 3. Additional Fees (Order Type)
            decimal additionalCharge = 0m;
            if (rdoTakeOut.Checked)
            {
                additionalCharge += 20m;
            }
            else if (rdoDelivery.Checked)
            {
                if (subtotal < 1000m)
                {
                    additionalCharge += 50m;
                }
            }

            // 4. Discount Calculations
            decimal discountPercentage = 0m;

            if (subtotal >= 500m)
            {
                discountPercentage += 0.10m;
            }

            if (chkSenior.Checked)
            {
                discountPercentage += 0.20m;
            }

            decimal totalDiscount = subtotal * discountPercentage;
            decimal finalTotal = (subtotal - totalDiscount) + additionalCharge;

            // 5. Payment & Change Verification
            if (payment < finalTotal)
            {
                MessageBox.Show("Insufficient payment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChange.Text = "Insufficient payment";
                return;
            }

            decimal change = payment - finalTotal;

            // 6. Output Results
            txtSubtotal.Text = $"₱{subtotal:N2}";
            txtDiscount.Text = $"₱{totalDiscount:N2}";
            txtTotal.Text = $"₱{finalTotal:N2}";
            txtChange.Text = $"₱{change:N2}";

            // 7. Pop-up Receipt
            DisplayReceipt(cmbFood.SelectedItem.ToString(), foodQty, foodPrice, foodTotal,
                           cmbDrink.SelectedItem.ToString(), drinkQty, drinkPrice, drinkTotal,
                           subtotal, totalDiscount, additionalCharge, finalTotal, payment, change);
        }
    }
}