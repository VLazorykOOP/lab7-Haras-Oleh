using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//форма з кодом для першого завдання
namespace laboratorna_robota7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        //задаємо на одну кнопочку дію додавання елементу з текстбоксу у випадаючий список
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        //задаємо на другу кнопочку дію вилучення елементу з текстбоксу у випадаючий список
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(textBox1.Text);
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
