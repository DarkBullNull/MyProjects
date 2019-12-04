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


            var sum1 = Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value) + Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value) + Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value);
            dataGridView1.Rows.Add("Всего осадков:", dataGridView1.Rows[0].Cells[1].Value);
                
            
        }

        int ValueColumn()
        {
            int p = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            return p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Всего осадков:", dataGridView1.Rows[0].Cells[1].Value);
        }
    }
}
