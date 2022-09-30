using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using susProject.Model;

namespace susProject
{
    public partial class Form3 : Form
    {
        XmlDocument xDoc = new XmlDocument();
        Workshop workshop = new Workshop();

        public Form3(Workshop workshop)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            this.workshop = workshop;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            double  text1 = double.Parse(text);
            workshop.LiningCoeff = text1;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            workshop.LiningCompleteneAmount = double.Parse(textBox2.Text);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            workshop.FabricProdRate = double.Parse(textBox3.Text);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            workshop.ShiftDuration = double.Parse(textBox4.Text); 
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            workshop.ShiftRate = double.Parse(textBox5.Text);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            workshop.TableArea = double.Parse(textBox6.Text);
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            workshop.LiningEquipmentArea = double.Parse(textBox7.Text);
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            workshop.WorkshopAreaUsageRate = double.Parse(textBox8.Text);
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            workshop.CuttingEquipmentArea = double.Parse(textBox9.Text);
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            workshop.CuttingMachineArea = double.Parse(textBox10.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            workshop.NumerationEquipmentArea = double.Parse(textBox11.Text);
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            workshop.ClericalTableArea = double.Parse(textBox12.Text);
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            workshop.LabelMachineArea = double.Parse(textBox13.Text);
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            workshop.DuplicationSpaceUsageRate = double.Parse(textBox14.Text);
        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            workshop.DuplicationPressArea = double.Parse(textBox15.Text);
        }
        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            workshop.ShelfSize = double.Parse(textBox16.Text);
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            workshop.CuttingStock = double.Parse(textBox17.Text);
        }
        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            workshop.LayerHeight = double.Parse(textBox18.Text);
        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            workshop.CuttingPacksInOneCell = double.Parse(textBox19.Text);
        }
        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            workshop.CoveringEquipmentArea = double.Parse(textBox20.Text);
        }
        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            workshop.QualityCheckTableArea = double.Parse(textBox21.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
            
        }
        private void xmlAdd()
        {
            xDoc.Load("DataWorkshop.xml");

            XmlNode workshopElem = xDoc.CreateElement("Workshop");
            xDoc.DocumentElement.AppendChild(workshopElem);

            XmlNode LiningCoeff = xDoc.CreateElement("LiningCoeff");
            LiningCoeff.InnerText = textBox1.Text;

            XmlNode LiningCompleteneAmount = xDoc.CreateElement("LiningCompleteneAmount");
            LiningCompleteneAmount.InnerText = textBox2.Text;

            XmlNode FabricProdRate = xDoc.CreateElement("FabricProdRate");
            FabricProdRate.InnerText = textBox3.Text;

            XmlNode ShiftDuration = xDoc.CreateElement("ShiftDuration");
            ShiftDuration.InnerText = textBox4.Text;

            XmlNode ShiftRate = xDoc.CreateElement("ShiftRate");
            ShiftRate.InnerText = textBox5.Text;

            XmlNode TableArea = xDoc.CreateElement("TableArea");
            TableArea.InnerText = textBox6.Text;

            XmlNode LiningEquipmentArea = xDoc.CreateElement("LiningEquipmentArea");
            LiningEquipmentArea.InnerText = textBox7.Text;

            XmlNode WorkshopAreaUsageRate = xDoc.CreateElement("WorkshopAreaUsageRate");
            WorkshopAreaUsageRate.InnerText = textBox8.Text;

            XmlNode CuttingEquipmentArea = xDoc.CreateElement("CuttingEquipmentArea");
            CuttingEquipmentArea.InnerText = textBox9.Text;

            XmlNode CuttingMachineArea = xDoc.CreateElement("CuttingMachineArea");
            CuttingMachineArea.InnerText = textBox10.Text;

            XmlNode NumerationEquipmentArea = xDoc.CreateElement("NumerationEquipmentArea");
            NumerationEquipmentArea.InnerText = textBox11.Text;

            XmlNode ClericalTableArea = xDoc.CreateElement("ClericalTableArea");
            ClericalTableArea.InnerText = textBox12.Text;

            XmlNode LabelMachineArea = xDoc.CreateElement("LabelMachineArea");
            LabelMachineArea.InnerText = textBox13.Text;

            XmlNode DuplicationSpaceUsageRate = xDoc.CreateElement("DuplicationSpaceUsageRate");
            DuplicationSpaceUsageRate.InnerText = textBox14.Text;

            XmlNode DuplicationPressArea = xDoc.CreateElement("DuplicationPressArea");
            DuplicationPressArea.InnerText = textBox15.Text;

            XmlNode ShelfSize = xDoc.CreateElement("ShelfSize");
            ShelfSize.InnerText = textBox16.Text;

            XmlNode CuttingStock = xDoc.CreateElement("CuttingStock");
            CuttingStock.InnerText = textBox17.Text;

            XmlNode LayerHeight = xDoc.CreateElement("LayerHeight");
            LayerHeight.InnerText = textBox18.Text;

            XmlNode CuttingPacksInOneCell = xDoc.CreateElement("CuttingPacksInOneCell");
            CuttingPacksInOneCell.InnerText = textBox19.Text;

            XmlNode LayingEquipmentArea = xDoc.CreateElement("LayingEquipmentArea");
            LayingEquipmentArea.InnerText = textBox20.Text;

            XmlNode QualityCheckTableArea = xDoc.CreateElement("QualityCheckTableArea");
            QualityCheckTableArea.InnerText = textBox21.Text;

            workshopElem.AppendChild(LiningCoeff);
            workshopElem.AppendChild(LiningCompleteneAmount);
            workshopElem.AppendChild(FabricProdRate);
            workshopElem.AppendChild(ShiftDuration);
            workshopElem.AppendChild(ShiftRate);
            workshopElem.AppendChild(TableArea);
            workshopElem.AppendChild(LiningEquipmentArea);
            workshopElem.AppendChild(WorkshopAreaUsageRate);
            workshopElem.AppendChild(CuttingEquipmentArea);
            workshopElem.AppendChild(CuttingMachineArea);
            workshopElem.AppendChild(NumerationEquipmentArea);
            workshopElem.AppendChild(ClericalTableArea);
            workshopElem.AppendChild(LabelMachineArea);
            workshopElem.AppendChild(DuplicationSpaceUsageRate);
            workshopElem.AppendChild(DuplicationPressArea);
            workshopElem.AppendChild(ShelfSize);
            workshopElem.AppendChild(CuttingStock);
            workshopElem.AppendChild(LayerHeight);
            workshopElem.AppendChild(CuttingPacksInOneCell);
            workshopElem.AppendChild(LayingEquipmentArea);
            workshopElem.AppendChild(QualityCheckTableArea);

            xDoc.Save("DataWorkshop.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xmlAdd();
        }
    }
}
