namespace Fast_Food
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            string orderSummary = "Seu pedido inclue:\n";

            if (chkHamburger.Checked)
                orderSummary += "- Hamburger\n";
            if (chkCheese.Checked)
                orderSummary += "- Queijo\n";
            if (chkLettuce.Checked)
                orderSummary += "- Alface\n";
            if (chkTomato.Checked)
                orderSummary += "- Tomate\n";

            if (!chkHamburger.Checked && !chkCheese.Checked && !chkLettuce.Checked && !chkTomato.Checked)
                orderSummary = "You didn't select any items.";

            txtOrderSummary.Text = orderSummary;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
