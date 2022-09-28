using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using susProject.Model;

namespace susProject
{
    public partial class Form4 : Form
    {
        List<Button> buttons = new List<Button>();
        XmlDocument xDoc = new XmlDocument();
        Product product = new Product();
        string materialName;

        public Form4(string materialName)
        {
            this.materialName = materialName;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            product.Name = textBox1.Text;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            double prodRelease = double.Parse(text);

            product.ProdReleaseAmount = prodRelease;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string text = textBox3.Text;
            double qualityCheck = double.Parse(text);

            product.QualityCheckTime = qualityCheck;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string text = textBox4.Text;
            double numTime = double.Parse(text);

            product.NumerationTime = numTime;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string text = textBox5.Text;
            double labelPrint = double.Parse(text);

            product.LabelPrintTime = labelPrint;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string text = textBox6.Text;
            double detaildDub = double.Parse(text);

            product.DetailsDuplicTime = detaildDub;
        }
        private void xmlAdd()
        {
            xDoc.Load("Data.xml");

            XmlNode prodElem = xDoc.CreateElement("Product");
            xDoc.DocumentElement.AppendChild(prodElem);

            XmlAttribute attribute = xDoc.CreateAttribute("name");
            attribute.Value = textBox1.Text;

            XmlNode amountElem = xDoc.CreateElement("ProdReleaseAmount");
            amountElem.InnerText = textBox2.Text;

            XmlNode qualityElem = xDoc.CreateElement("QualityCheckTime");
            qualityElem.InnerText = textBox3.Text;

            XmlNode numerElem = xDoc.CreateElement("NumerationTime");
            numerElem.InnerText = textBox4.Text;

            XmlNode labelElem = xDoc.CreateElement("LabelPrintTime");
            labelElem.InnerText = textBox5.Text;

            XmlNode detailsElem = xDoc.CreateElement("DetailsDuplicTime");
            detailsElem.InnerText = textBox6.Text;

            prodElem.AppendChild(amountElem);
            prodElem.AppendChild(qualityElem);
            prodElem.AppendChild(numerElem);
            prodElem.AppendChild(labelElem);
            prodElem.AppendChild(detailsElem);

            prodElem.Attributes.Append(attribute);

            xDoc.Save("Data.xml");
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
                top += materialButton.Height + 2;
                materialButton.Name = $"button{i+1}";
                materialButton.Click += button_Click;

                buttons.Add(materialButton);
                this.Controls.Add(materialButton);

                Console.WriteLine(buttons[i]);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            Form5 form5 = new Form5(material, product);
            form5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xmlAdd();
        }

    }
}
