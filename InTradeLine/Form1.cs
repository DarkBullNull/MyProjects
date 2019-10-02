using System;
using System.Windows.Forms;

namespace InTradeLine
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            
            courseDollar.Text += dollar + " руб.";
            courseEuro.Text += euro + " руб.";
            courseBTC.Text += btc + " руб.";
            courseETH.Text += eth + " руб.";
        }
        double dollar = Convert.ToDouble(ParseValue.ParseDollar());
        double euro = Convert.ToDouble(ParseValue.ParseEuro());
        double btc = Convert.ToDouble(ParseValue.ParseBTC());
        double eth = Convert.ToDouble(ParseValue.ParseETH());
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((comboBox1.Text == "Российский рубль") & (comboBox2.Text == "Доллар США"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) / dollar), 5).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CheckConnect.CheckSocket())
            {
                
                this.Text += " [Подключение установлено]";
            }
            else
            {
                Form1 mainForm = new Form1();
                this.Text += " [Подключение НЕ установлено]";
            }
        }
    }
}
