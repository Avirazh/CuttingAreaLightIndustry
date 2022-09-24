using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace susProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string count = textBox1.Text;

            Button setMaterial = new Button();
            setMaterial.Text = count;
            this.Controls.Add(setMaterial);

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string count = comboBox1.SelectedItem.ToString();
            int count1 = int.Parse(count);

            int top = 50;
            int left = 100;

            for (int i = 0; i < count1; i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                this.Controls.Add(button);
                Console.WriteLine(1);
                top += button.Height + 2;
            }
        }
    }
}
