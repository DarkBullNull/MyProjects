using System;
using System.Windows.Forms;

namespace InTradeLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double dollar = Convert.ToDouble(ParseValue.ParseDollar());
            double euro = Convert.ToDouble(ParseValue.ParseEuro());
            double btc = Convert.ToDouble(ParseValue.ParseBTC());
            double eth = Convert.ToDouble(ParseValue.ParseETH());
            courseDollar.Text += dollar + " руб.";
            courseEuro.Text += euro + " руб.";
            courseBTC.Text += btc + " руб.";
            courseETH.Text += eth + " руб.";
        }
    }
}
