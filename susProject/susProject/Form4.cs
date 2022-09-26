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
        public string InboxData = "";
        List<Button> buttons = new List<Button>();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    this.Controls.Remove(buttons[i]);
                }
            }

            string count = comboBox1.SelectedItem.ToString();
            int count1 = int.Parse(count);

            int top = 270;
            int left = 285;


            for (int i = 0; i < count1; i++)
            {
                Button materialButton = new Button();
                materialButton.Left = left;
                materialButton.Top = top;
                materialButton.Text = $"Материал {i + 1}";
                buttons.Add(materialButton);
                this.Controls.Add(materialButton);
                top += materialButton.Height + 2;
            }
        }
    }
}
