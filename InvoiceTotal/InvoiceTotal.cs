using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class InvoiceTotal : Form
    {
        public InvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = 0m;

            if (subtotal >= 500)
                discountPercent = .2m;
            else if (subtotal >= 250 && subtotal < 500)
                discountPercent = .15m;
            else if (subtotal >= 100 && subtotal < 250)
                discountPercent = .1m;

            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString();
            txtDiscountAmount.Text = discountAmount.ToString();
            txtTotal.Text = invoiceTotal.ToString();

            txtSubtotal.Focus();
        }
    }
}
