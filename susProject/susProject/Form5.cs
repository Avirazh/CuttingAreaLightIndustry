using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using susProject.Model;

namespace susProject
{
    public partial class Form5 : Form
    {
        XmlDocument xDoc = new XmlDocument();
        Material material = new Material();

        public Form5(Material material, Product product)
        {
            this.material = material;
            product.Materials.Add(material);
            material.Product = product;
            InitializeComponent();
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            material.Name = textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            material.CoveringHeight = double.Parse(textBox2.Text);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            material.ConsumptionRate = double.Parse(textBox3.Text);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            material.LiningsTime = double.Parse(textBox4.Text);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            material.CoveringQualityCheckTime = double.Parse(textBox5.Text);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            material.CoveringBrandingTime = double.Parse(textBox6.Text);
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            material.CoveringCuttingTime = double.Parse(textBox7.Text);
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            material.CoveringRemovalTime = double.Parse(textBox8.Text);
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            material.MaterialCoveringTime = double.Parse(textBox9.Text);
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            material.DetailsCuttingTime = double.Parse(textBox10.Text);
        }
        private void xmlAdd()
        {
            xDoc.Load("Data.xml");

            XmlNode materialElem = xDoc.CreateElement("Material");
            xDoc.DocumentElement.AppendChild(materialElem);

            XmlAttribute attribute = xDoc.CreateAttribute("name");
            attribute.Value = textBox1.Text;

            XmlNode CoveringHeight = xDoc.CreateElement("CoveringHeight");
            CoveringHeight.InnerText = textBox2.Text;

            XmlNode ConsumptionRate = xDoc.CreateElement("ConsumptionRate");
            ConsumptionRate.InnerText = textBox3.Text;

            XmlNode LiningsTime = xDoc.CreateElement("LiningsTime");
            LiningsTime.InnerText = textBox4.Text;

            XmlNode CoveringQualityCheckTime = xDoc.CreateElement("CoveringQualityCheckTime");
            CoveringQualityCheckTime.InnerText = textBox5.Text;

            XmlNode CoveringBrandingTime = xDoc.CreateElement("CoveringBrandingTime");
            CoveringBrandingTime.InnerText = textBox6.Text;

            XmlNode CoveringCuttingTime = xDoc.CreateElement("CoveringCuttingTime");
            CoveringCuttingTime.InnerText = textBox7.Text;

            XmlNode CoveringRemovalTime = xDoc.CreateElement("CoveringRemovalTime");
            CoveringRemovalTime.InnerText = textBox8.Text;

            XmlNode MaterialCoveringTime = xDoc.CreateElement("MaterialCoveringTime");
            MaterialCoveringTime.InnerText = textBox9.Text;

            XmlNode DetailsCuttingTime = xDoc.CreateElement("DetailsCuttingTime");
            DetailsCuttingTime.InnerText = textBox10.Text;

            materialElem.AppendChild(CoveringHeight);
            materialElem.AppendChild(ConsumptionRate);
            materialElem.AppendChild(LiningsTime);
            materialElem.AppendChild(CoveringQualityCheckTime);
            materialElem.AppendChild(CoveringBrandingTime);
            materialElem.AppendChild(CoveringRemovalTime);
            materialElem.AppendChild(MaterialCoveringTime);
            materialElem.AppendChild(DetailsCuttingTime);

            materialElem.Attributes.Append(attribute);

            xDoc.Save("Data.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xmlAdd();
        }
    }
}
