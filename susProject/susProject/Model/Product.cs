using System.Collections.Generic;

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
        /// <summary>
        /// Кол-во раб. и обор-я. Пров-ка кач-ва сборки и компл.кроя Kст.комп= Nкомп
        /// </summary>
        public double QualityCheckAmount { get; set; }
        /// <summary>
        /// Кол-во раб. и обор-я. Нумерац.участок Кнум= Nнум
        /// </summary>
        public double NumeratingAmount { get; set; }
        /// <summary>
        /// Кол-во раб. и обор-я. Печ.ярлык.участок Кп.я.= Nп.я
        /// </summary>
        public double BrandingAmount { get; set; }
        /// <summary>
        /// Кол-во раб. и обор-я. Предварит.подготов.участок Кпр= Nпр
        /// </summary>
        public double PreparationAreaAmount { get; set; }


        public List<Material> AddMaterial(Material material)
        {
            Materials.Add(material);
            return Materials;
        }
    }
}
