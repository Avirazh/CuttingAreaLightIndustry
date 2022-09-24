using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susProject.Model
{
    public class Product
    {
        public string Name { get; set; }

        public List<Material> Materials { get; set; }

        /// <summary>
        /// Выпуск изделий М, ед./см 
        /// </summary>
        public double ProdReleaseAmount { get; set; }
        /// <summary>
        /// Время на проверку качества сборки и комплектования дет.кроя (tкомп)
        /// </summary>
        public double QualityCheckTime { get; set; }
        /// <summary>
        /// Время на нумерацию дет.кроя (tнум)
        /// </summary>
        public double NumerationTime { get; set; }
        /// <summary>
        /// Время на печатание тов. ярлыков (tп.я)
        /// </summary>
        public double LabelPrintTime { get; set; }
        /// <summary>
        /// Время на дублирование деталей (tпр)
        /// </summary>
        public double DetailsDuplicTime { get; set; }

        public List<Material> AddMaterial(Material material)
        {
            Materials.Add(material);
            return Materials;
        }
    }
}
