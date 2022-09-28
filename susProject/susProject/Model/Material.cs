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

        /// <summary>
        /// пачки кроя nпач
        /// </summary>
        public double CutPacks { get; set; }
        /// <summary>
        /// кол-во обмеловок nоб
        /// </summary>
        public double LiningAmount { get; set; }
        /// <summary>
        /// Кол-во раб. и обор-я. Обелов.участок Nоб=Кст.об
        /// </summary>
        public double LiningWorkersAmount { get; set; }
        /// <summary>
        /// Суточ.потреб-ть мат-ов L
        /// </summary>
        public double DailyRequirement { get; set; }
        /// <summary>
        /// Настл.столы Кнст
        /// </summary>
        public double CoveringTableAmount { get; set; }
        /// <summary>
        /// Рабочие настил. Nнастил
        /// </summary>
        public double CoveringWorkersAmount { get; set; }
        /// <summary>
        /// Рабочие контроль и подмел. Nконтр.кол.и подмел
        /// </summary>
        public double QualityWorkersAmount { get; set; }
        /// <summary>
        /// Рабочие клемен. Nклейм
        /// </summary>
        public double BrandingWorkersAmount { get; set; }
        /// <summary>
        /// Рабочие рассек. Nрассек.
        /// </summary>
        public double CuttingWorkersAmount { get; set; }
        /// <summary>
        /// Раб. Съем Nсъем
        /// </summary>
        public double RemovalWorkersAmount { get; set; }
        /// <summary>
        /// кол-во рабочих настил.уч Nосн
        /// </summary>
        public double CoveringSpaceWorkersAmount { get; set; }
        /// <summary>
        /// Кол-во раб. и обор-я. Выр.дет.кр.участок Кст.р.м= Nрез
        /// </summary>
        public double CuttingDetailsWorkersAmount { get; set; }
    }
}
