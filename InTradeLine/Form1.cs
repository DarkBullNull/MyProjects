using System;
using System.Threading.Tasks;
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
        async private void textBox1_TextChanged(object sender, EventArgs e)
        {
            reCheck:
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
            if ((comboBox1.Text == "Российский рубль") & (comboBox2.Text == "Bitcoin"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) / btc), 12).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Российский рубль") & (comboBox2.Text == "Ethereum"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) / eth), 12).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Российский рубль") & (comboBox2.Text == "Евро"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) / euro), 5).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Доллар США") & (comboBox2.Text == "Bitcoin"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * dollar / btc), 12).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Доллар США") & (comboBox2.Text == "Российский рубль"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * dollar / 1), 5).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Доллар США") & (comboBox2.Text == "Евро"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * dollar / euro), 5).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Доллар США") & (comboBox2.Text == "Ethereum"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * dollar / eth), 12).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Евро") & (comboBox2.Text == "Российский рубль"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * euro / 1), 5).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Евро") & (comboBox2.Text == "Доллар США"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * euro / dollar), 5).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Евро") & (comboBox2.Text == "Bitcoin"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * euro / btc), 12).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Евро") & (comboBox2.Text == "Ethereum"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * euro / eth), 12).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Bitcoin") & (comboBox2.Text == "Российский рубль"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * btc / 1), 5).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Bitcoin") & (comboBox2.Text == "Доллар США"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * btc / dollar), 5).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Bitcoin") & (comboBox2.Text == "Евро"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * btc / euro), 5).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Bitcoin") & (comboBox2.Text == "Ethereum"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * btc / eth), 12).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Ethereum") & (comboBox2.Text == "Российский рубль"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * eth / 1), 12).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Ethereum") & (comboBox2.Text == "Доллар США"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * eth / dollar), 5).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Ethereum") & (comboBox2.Text == "Евро"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * eth / euro), 5).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            if ((comboBox1.Text == "Ethereum") & (comboBox2.Text == "Bitcoin"))
            {
                try
                {
                    result.Text = " = " + Math.Round((Convert.ToDouble(textBox1.Text) * eth / 12), 12).ToString();
                }
                catch (Exception)
                {

                    result.Text = "Что-то не то!";
                }
            }
            await Task.Delay(500);
            goto reCheck;
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
