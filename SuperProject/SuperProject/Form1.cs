using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Введите ваш год рождения";
            textBox2.Text = "Введите текущий год";
        }
        void TextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
        }
        private void TextBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
        }
        void Form1_Load(object sender, System.EventArgs e)
        {
            Refreshtb1();
            Refreshtb2();
            Refreshcb1();
        }
        public async void Refreshtb1()
        {
        RefreshTB1:
            if (textBox1.Text != "")
            {
                await Task.Delay(4000);
                goto RefreshTB1;
            }
            else
            {
                textBox1.Text = "Введите ваш год рождения";
                goto RefreshTB1;
            }
        }
        public async void Refreshtb2()
        {
        RefreshTB2:
            if (textBox2.Text != "")
            {
                await Task.Delay(4000);
                goto RefreshTB2;
            }
            else
            {
                textBox2.Text = "Введите текущий год";
                goto RefreshTB2;
            }
        }
        public async void Refreshcb1()
        {
        RefreshCB1:
            await Task.Delay(100);
            if (textBox1.Text == textBox2.Text)
            {
                checkBox1.Enabled = false;
                goto RefreshCB1;
            }
            else
            {
                checkBox1.Enabled = true;
                goto RefreshCB1;
            };

        }
        void Button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) >= (DateTime.Now.Year - 100) && Convert.ToInt32(textBox1.Text) <= DateTime.Now.Year
                    && Convert.ToInt32(textBox2.Text) >= (DateTime.Now.Year - 100) && Convert.ToInt32(textBox2.Text) <= DateTime.Now.Year)
                {
                    if (checkBox1.Checked == true)
                    {
                        label1.Text = (Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text) - 1).ToString();
                    }
                    else
                    {
                        label1.Text = (Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text)).ToString();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Неправильно введены числа", "Что-то не то!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
