using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InTradeLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextChange();
            courseDollar.Text += dollar + " руб.";
            courseEuro.Text += euro + " руб.";
            courseBTC.Text += btc + " руб.";
            courseETH.Text += eth + " руб.";
            //int IndexCombobox1 = Convert.ToInt32(comboBox1.SelectedItem);
            //int IndexCombobox2 = Convert.ToInt32(comboBox2.SelectedItem);
        }
        double dollar = Convert.ToDouble(ParseValue.ParseDollar());
        double euro = Convert.ToDouble(ParseValue.ParseEuro());
        double btc = Convert.ToDouble(ParseValue.ParseBTC());
        double eth = Convert.ToDouble(ParseValue.ParseETH());

        async void TextChange()
        {
            reCheck:
            try
            {
                if ((comboBox1.Text == "Российский рубль") & (comboBox2.Text == "Доллар США"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) / dollar), 5).ToString();
                }
                if ((comboBox1.Text == "Российский рубль") & (comboBox2.Text == "Bitcoin"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) / btc), 12).ToString();
                }
                if ((comboBox1.Text == "Российский рубль") & (comboBox2.Text == "Ethereum"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) / eth), 12).ToString();
                }
                if ((comboBox1.Text == "Российский рубль") & (comboBox2.Text == "Евро"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) / euro), 5).ToString();
                }
                if ((comboBox1.Text == "Доллар США") & (comboBox2.Text == "Bitcoin"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * dollar / btc), 12).ToString();
                }
                if ((comboBox1.Text == "Доллар США") & (comboBox2.Text == "Российский рубль"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * dollar / 1), 5).ToString();
                }
                if ((comboBox1.Text == "Доллар США") & (comboBox2.Text == "Евро"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * dollar / euro), 5).ToString();
                }
                if ((comboBox1.Text == "Доллар США") & (comboBox2.Text == "Ethereum"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * dollar / eth), 12).ToString();
                }
                if ((comboBox1.Text == "Евро") & (comboBox2.Text == "Российский рубль"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * euro / 1), 5).ToString();
                }
                if ((comboBox1.Text == "Евро") & (comboBox2.Text == "Доллар США"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * euro / dollar), 5).ToString();
                }
                if ((comboBox1.Text == "Евро") & (comboBox2.Text == "Bitcoin"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * euro / btc), 12).ToString();
                }
                if ((comboBox1.Text == "Евро") & (comboBox2.Text == "Ethereum"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * euro / eth), 12).ToString();
                }
                if ((comboBox1.Text == "Bitcoin") & (comboBox2.Text == "Российский рубль"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * btc / 1), 5).ToString();
                }
                if ((comboBox1.Text == "Bitcoin") & (comboBox2.Text == "Доллар США"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * btc / dollar), 5).ToString();
                }
                if ((comboBox1.Text == "Bitcoin") & (comboBox2.Text == "Евро"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * btc / euro), 5).ToString();
                }
                if ((comboBox1.Text == "Bitcoin") & (comboBox2.Text == "Ethereum"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * btc / eth), 12).ToString();
                }
                if ((comboBox1.Text == "Ethereum") & (comboBox2.Text == "Российский рубль"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * eth / 1), 12).ToString();
                }
                if ((comboBox1.Text == "Ethereum") & (comboBox2.Text == "Доллар США"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * eth / dollar), 5).ToString();
                }
                if ((comboBox1.Text == "Ethereum") & (comboBox2.Text == "Евро"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * eth / euro), 5).ToString();
                }
                if ((comboBox1.Text == "Ethereum") & (comboBox2.Text == "Bitcoin"))
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * eth / 12), 12).ToString();
                }
            }
            catch (Exception)
            {
                result.Text = "Что-то не то";
            }
            await Task.Delay(500);
            goto reCheck;
        }
    }
}
