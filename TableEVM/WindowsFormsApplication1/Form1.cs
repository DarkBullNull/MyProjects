using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            var rnd = new Random();
            var column0 = new DataGridViewColumn();

            





            column0.HeaderText = ""; //текст в шапке
            column0.Width = 100; //ширина колонки
            column0.ReadOnly = true; //значение в этой колонке нельзя править
            column0.Name = "key"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column0.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column0.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Зима";
            column1.Name = "winter";
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Весна";
            column2.Name = "spring";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Лето";
            column3.Name = "summer";
            column3.CellTemplate = new DataGridViewTextBoxCell();


            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Осень";
            column4.Name = "autumn";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column0);
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);

            dataGridView1.AllowUserToAddRows = false;

            for (int i = 1; i < 4; ++i)
            {
                //Добавляем строку, указывая значения колонок поочереди слева направо
                dataGridView1.Rows.Add("Месяц " + i, rnd.Next(0, 1144) + " мм", rnd.Next(0, 1144) + " мм", rnd.Next(0, 1144) + " мм", rnd.Next(0, 1144) + " мм");
            }


            var sum_winter = 
                  Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value.ToString().Replace(" мм", ""))
                + Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value.ToString().Replace(" мм", ""))
                + Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value.ToString().Replace(" мм", ""));
            var sum_spring =
                  Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value.ToString().Replace(" мм", ""))
                + Convert.ToInt32(dataGridView1.Rows[1].Cells[2].Value.ToString().Replace(" мм", ""))
                + Convert.ToInt32(dataGridView1.Rows[2].Cells[2].Value.ToString().Replace(" мм", ""));
            var sum_summer =
                  Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace(" мм", ""))
                + Convert.ToInt32(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace(" мм", ""))
                + Convert.ToInt32(dataGridView1.Rows[2].Cells[3].Value.ToString().Replace(" мм", ""));
            var sum_autumn =
                  Convert.ToInt32(dataGridView1.Rows[0].Cells[4].Value.ToString().Replace(" мм", ""))
                + Convert.ToInt32(dataGridView1.Rows[1].Cells[4].Value.ToString().Replace(" мм", ""))
                + Convert.ToInt32(dataGridView1.Rows[2].Cells[4].Value.ToString().Replace(" мм", ""));
            dataGridView1.Rows.Add("Всего осадков:", sum_winter + " мм", sum_spring + " мм", sum_summer + " мм", sum_autumn + " мм");
            /*=======================================BIG=========================================*/
            if (sum_autumn > sum_spring && sum_autumn > sum_winter && sum_autumn > sum_summer)
            {
                label_result_big.Text = "Больше всего осадков выпало осенью: " + sum_autumn + " мм";
            }
            else if (sum_winter > sum_spring && sum_winter > sum_summer && sum_winter > sum_autumn)
            {
                label_result_big.Text = "Больше всего осадков выпало зимой: " + sum_winter + " мм";
            }
            else if (sum_spring > sum_winter && sum_spring > sum_summer && sum_spring > sum_autumn)
            {
                label_result_big.Text = "Больше всего осадков выпало весной: " + sum_spring + " мм";
            }
            else if (sum_summer > sum_winter && sum_summer > sum_spring && sum_summer > sum_autumn)
            {
                label_result_big.Text = "Больше всего осадков выпало летом: " + sum_summer + " мм";
            }
            /*=======================================SMALL=========================================*/
            if (sum_autumn < sum_spring && sum_autumn < sum_winter && sum_autumn < sum_summer)
            {
                label_result_small.Text = "Меньше всего осадков выпало осенью: " + sum_autumn + " мм";
            }
            else if (sum_winter < sum_spring && sum_winter < sum_summer && sum_winter < sum_autumn)
            {
                label_result_small.Text = "Меньше всего осадков выпало зимой: " + sum_winter + " мм";
            }
            else if (sum_spring < sum_winter && sum_spring < sum_summer && sum_spring < sum_autumn)
            {
                label_result_small.Text = "Меньше всего осадков выпало весной: " + sum_spring + " мм";
            }
            else if (sum_summer < sum_winter && sum_summer < sum_spring && sum_summer < sum_autumn)
            {
                label_result_small.Text = "Меньше всего осадков выпало летом: " + sum_summer + " мм";
            }
        }

        
    }
}
