namespace susProject.Model
{
    public class Material
    {
        public string Name { get; set; }
        public Product Product { get; set; }
        /// <summary>
        /// Высота настила hн, м
        /// </summary>
        public double CoveringHeight { get; set; }
        /// <summary>
        /// Отраслевые нормы расхода
        /// </summary>
        public double ConsumptionRate { get; set; }
        /// <summary>
        /// обмеловки (toб)
        /// </summary>
        public double LiningsTime { get; set; }
        /// <summary>
        /// Контроля качества и подмелки контуров деталей на верх. полотне настила (tподм)
        /// </summary>
        public double CoveringQualityCheckTime { get; set; }
        /// <summary>
        /// Клеймения настила tкл
        /// </summary>
        public double CoveringBrandingTime { get; set; }
        /// <summary>
        /// Рассекания настила (tрас)
        /// </summary>
        public double CoveringCuttingTime { get; set; }
        /// <summary>
        /// Съем настила tс
        /// </summary>
        public double CoveringRemovalTime { get; set; }
        /// <summary>
        /// Настилания материала (tвр)
        /// </summary>
        public double MaterialCoveringTime { get; set; }
        /// <summary>
        /// Вырезания средних и мелких деталей (tвыр)
        /// </summary>
        public double DetailsCuttingTime { get; set; }
        /// <summary>
        /// Нанесения контуров лекал (опционально)
        /// </summary>
        public double PatternContoursTime { get; set; }
    }
}
