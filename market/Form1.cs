namespace market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbbvat.Visible = false;
            lbvat.Visible = false;
            lbpricepvat.Visible = false;
            lbmemprice.Visible = false;
            lblre.Visible = false;
            lbk1000.Visible = false;
            lbk500.Visible = false;
            lbk100.Visible = false;
            lbk50.Visible = false;
            lbk20.Visible = false;
            lbk10.Visible = false;
            lbk5.Visible = false;
            lbk1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbcash.Text != "" && tbprice.Text != "")
            {
                double cash, remain;
                double price = Convert.ToDouble(tbprice.Text);
                cash = Convert.ToDouble(tbcash.Text);
                if (cash >= price)
                {
                    lbbvat.Text = "price before VAT : " + price + " Baht";


                    double vat = price * 0.07;
                    lbvat.Text = "VAT : " + vat.ToString("#.##") + " Baht";

                    double pricepvat = price + vat;
                    lbpricepvat.Text = "price + VAT : " + pricepvat.ToString("#.##") + " Baht";

                    remain = cash - pricepvat;

                    if (cbmember.Checked)
                    {
                        double pricemem;
                        if (pricepvat > 1000)
                        {
                            pricemem = pricepvat * 0.95;


                        }
                        else
                        {
                            pricemem = pricepvat * 0.97;

                        }
                        remain = cash - pricemem;
                        lbmemprice.Text = "membership price : " + pricemem.ToString("#.##") + " Baht";
                    }
                    else
                    {
                        lbmemprice.Text = "You're not a member";

                    }


                    lblre.Text = "change : " + remain.ToString("#.##") + " Baht";






                    double k1000 = 0, k500 = 0, k100 = 0, k50 = 0, k20 = 0, k10 = 0, k5 = 0, k1 = 0, modu = 0, left = 0;
                    left = remain;
                    for (int i = 0; i < 10; i++)
                    {

                        if (left >= 1000)
                        {

                            modu = (remain % 1000);
                            remain -= modu;
                            k1000 = remain / 1000;
                            left -= k1000 * 1000;
                            remain = left;

                        }
                        else if (left >= 500)
                        {
                            modu = (remain % 500);
                            remain -= modu;
                            k500 = remain / 500;
                            left -= k500 * 500;
                            remain = left;

                        }
                        else if (left >= 100)
                        {
                            modu = (remain % 100);
                            remain -= modu;
                            k100 = remain / 100;
                            left -= k100 * 100;
                            remain = left;

                        }
                        else if (left >= 50)
                        {
                            modu = (remain % 50);
                            remain -= modu;
                            k50 = remain / 50;
                            left -= k50 * 50;
                            remain = left;

                        }
                        else if (left >= 20)
                        {
                            modu = (remain % 20);
                            remain -= modu;
                            k20 = remain / 20;
                            left -= k20 * 20;
                            remain = left;

                        }
                        else if (left >= 10)
                        {
                            modu = (remain % 10);
                            remain -= modu;
                            k10 = remain / 10;
                            left -= k10 * 10;
                            remain = left;

                        }
                        else if (left >= 5)
                        {
                            modu = (remain % 5);
                            remain -= modu;
                            k5 = remain / 5;
                            left -= k5 * 5;
                            remain = left;

                        }
                        else
                        {
                            modu = (remain % 1);
                            remain -= modu;
                            k1 = remain / 1;
                            left -= k1 * 1;

                        }
                        lbk1000.Text = "1000 x " + k1000.ToString();
                        lbk500.Text = "500 x " + k500.ToString();
                        lbk100.Text = "100 x " + k100.ToString();
                        lbk50.Text = "50 x " + k50.ToString();
                        lbk20.Text = "20 x " + k20.ToString();
                        lbk10.Text = "10 x " + k10.ToString();
                        lbk5.Text = "5 x " + k5.ToString();
                        lbk1.Text = "1 x " + k1.ToString();

                    }
                    lbbvat.Visible = true;
                    lbvat.Visible = true;
                    lbpricepvat.Visible = true;
                    lbmemprice.Visible = true;
                    lblre.Visible = true;
                    lbk1000.Visible = true;
                    lbk500.Visible = true;
                    lbk100.Visible = true;
                    lbk50.Visible = true;
                    lbk20.Visible = true;
                    lbk10.Visible = true;
                    lbk5.Visible = true;
                    lbk1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Your cash is not enough");
                }




            }
            else
            {
                MessageBox.Show("pls complete input first");
            }
        }

        private void tbprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cInt = Convert.ToInt32(e.KeyChar);
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57 || (int)e.KeyChar == 8 || (int)e.KeyChar == 46)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbcash_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cInt = Convert.ToInt32(e.KeyChar);
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57 || (int)e.KeyChar == 8 || (int)e.KeyChar == 46)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}