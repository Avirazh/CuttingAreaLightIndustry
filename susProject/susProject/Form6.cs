using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using susProject.Logic;
using susProject.Model;

namespace susProject
{
    public partial class Form6 : Form
    {
        public Form6(Result result)
        {
            InitializeComponent();
            label23.Text = result.lining.EstWorkersQuantity.ToString();
            label24.Text = result.lining.ActualWorkersQuantity.ToString();
            label25.Text = result.lining.EquipmentAmount.ToString();
            label26.Text = result.lining.AreaUsageTotalRate.ToString();
            label27.Text = result.lining.LandArea.ToString();

            label28.Text = result.covering.EstWorkersQuantity.ToString();
            label29.Text = result.covering.ActualWorkersQuantity.ToString();
            label30.Text = result.covering.EquipmentAmount.ToString();
            label31.Text = result.covering.AreaUsageTotalRate.ToString();
            label32.Text = result.covering.LandArea.ToString();

            label33.Text = result.matCovering.EstWorkersQuantity.ToString();

            label38.Text = result.qualityCheckCovering.EstWorkersQuantity.ToString();

            label43.Text = result.labelCovering.EstWorkersQuantity.ToString();

            label48.Text = result.cutCovering.EstWorkersQuantity.ToString();

            label53.Text = result.removeCovering.EstWorkersQuantity.ToString();

            label58.Text = result.cutting.EstWorkersQuantity.ToString();
            label59.Text = result.cutting.ActualWorkersQuantity.ToString();
            label60.Text = result.cutting.EquipmentAmount.ToString();
            label61.Text = result.cutting.AreaUsageTotalRate.ToString();
            label62.Text = result.cutting.LandArea.ToString();

            label63.Text = result.processing.EstWorkersQuantity.ToString();
            label64.Text = result.processing.ActualWorkersQuantity.ToString();
            label65.Text = result.processing.EquipmentAmount.ToString();
            label66.Text = result.processing.AreaUsageTotalRate.ToString();
            label67.Text = result.processing.LandArea.ToString();

            label68.Text = result.qualityCheckProcessing.EstWorkersQuantity.ToString();

            label73.Text = result.numeratingProcessing.EstWorkersQuantity.ToString();

            label78.Text = result.labeling.EstWorkersQuantity.ToString();
            label79.Text = result.labeling.ActualWorkersQuantity.ToString();
            label80.Text = result.labeling.EquipmentAmount.ToString();
            label81.Text = result.labeling.AreaUsageTotalRate.ToString();
            label82.Text = result.labeling.LandArea.ToString();

            label83.Text = result.defected.EstWorkersQuantity.ToString();
            label84.Text = result.defected.ActualWorkersQuantity.ToString();
            label85.Text = result.defected.EquipmentAmount.ToString();
            label86.Text = result.defected.AreaUsageTotalRate.ToString();
            label87.Text = result.defected.LandArea.ToString();

            label88.Text = result.storage.EstWorkersQuantity.ToString();
            label89.Text = result.storage.ActualWorkersQuantity.ToString();
            label90.Text = result.storage.EquipmentAmount.ToString();
            label91.Text = result.storage.AreaUsageTotalRate.ToString();
            label92.Text = result.storage.LandArea.ToString();

            label93.Text = result.duplicate.EstWorkersQuantity.ToString();
            label94.Text = result.duplicate.ActualWorkersQuantity.ToString();
            label95.Text = result.duplicate.EquipmentAmount.ToString();
            label96.Text = result.duplicate.AreaUsageTotalRate.ToString();
            label97.Text = result.duplicate.LandArea.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
