namespace susProject.Model
{
    public class Workshop
    {
        public string Name { get; set; }

        /// <summary>
        /// Коэф., учитывающий работы в связи с выполнением доп. обмеловок на деф. полотнах К0
        /// </summary>
        public double LiningCoeff { get; set; }
        /// <summary>
        /// комплектность обмеловки nед
        /// </summary>
        public double LiningCompleteneAmount { get; set; }
        /// <summary>
        /// Норма выработки бригады из 2х настильщиц Нвыр, м/см
        /// </summary>
        public double FabricProdRate { get; set; }
        /// <summary>
        /// Продолжительность смены Тсм, с
        /// </summary>
        public double ShiftDuration { get; set; }
        /// <summary>
        /// коэф сменности Ксм
        /// </summary>
        public double ShiftRate { get; set; }
        /// <summary>
        /// Площадь 1ого стола Sст.об., м2
        /// </summary>
        public double TableArea { get; set; }
        /// <summary>
        /// Площадь прочего оборудования (обмеловка) Sпр., м2
        /// </summary>
        public double LiningEquipmentArea { get; set; }
        /// <summary>
        /// Коэф. использования площади цеха Кпл.
        /// </summary>
        public double WorkshopAreaUsageRate { get; set; }
        /// <summary>
        /// Площадь прочего оборудования (вырезания деталей) Sвыр.пр.об., м2
        /// </summary>
        public double CuttingEquipmentArea { get; set; }
        /// <summary>
        /// Площадь стационарной раскройной ленточной машины S ст.р.м, м2
        /// </summary>
        public double CuttingMachineArea { get; set; }
        /// <summary>
        /// Площадь обор-я для нумерации деталей кроя S об.нум., м2
        /// </summary>
        public double NumerationEquipmentArea { get; set; }
        /// <summary>
        /// Площадь канцелярского стола Sст., м2
        /// </summary>
        public double ClericalTableArea { get; set; }
        /// <summary>
        /// Площадь печатного автомата для печатания торговых ярлыков, Sп.я., м2
        /// </summary>
        public double LabelMachineArea { get; set; }
        /// <summary>
        /// Коэф. Исп-я площади участка дублирования Кпл.
        /// </summary>
        public double DuplicationSpaceUsageRate { get; set; }
        /// <summary>
        /// Площадь дублирующего пресса Sпр, м2
        /// </summary>
        public double DuplicationPressArea { get; set; }
        /// <summary>
        /// Объем полки V, м3
        /// </summary>
        public double ShelfSize { get; set; }
        /// <summary>
        /// Запас кроя на складе Z, дни
        /// </summary>
        public double CuttingStock { get; set; }
        /// <summary>
        /// Высота яруса укладки hяр, м
        /// </summary>
        public double LayerHeight { get; set; }
        /// <summary>
        /// Кол-во пачек кроя, вмещ. в одну клетку m
        /// </summary>
        public double CuttingPacksInOneCell { get; set; }
        /// <summary>
        /// Площадь прочего об-я (настилание) Sпр.об.
        /// </summary>
        public double CoveringEquipmentArea { get; set; }
        /// <summary>
        /// Площадь стола для проверки качества сбори и комплектовки Sкомп
        /// </summary>
        public double QualityCheckTableArea { get; set; }


        /// <summary>
        /// Площадь обмелов.уч. Sоб
        /// </summary>
        public double LiningArea { get; set; }
        /// <summary>
        /// Площадь настил. Sнаст
        /// </summary>
        public double CoveringArea { get; set; }
        /// <summary>
        /// Площадь выр.дет. Sвыр
        /// </summary>
        public double CuttingDetailsArea { get; set; }
        /// <summary>
        /// Площадь обраб.кроя Sобр.кр
        /// </summary>
        public double CutProcessingArea { get; set; }
        /// <summary>
        /// Площадь комплектов-я. Sкомп
        /// </summary>
        public double GatheringArea { get; set; }
        /// <summary>
        /// Площадь нумер. Sнум
        /// </summary>
        public double NumeratingArea { get; set; }
        /// <summary>
        /// Площадь печ.ярлык. и оформл.док. Sо.д
        /// </summary>
        public double BrandingArea { get; set; }
        /// <summary>
        /// Площадь дублир-я Sдубл
        /// </summary>
        public double DuplicationArea { get; set; }
        /// <summary>
        /// Площадь обр.деф.полот. Sдеф.пл
        /// </summary>
        public double DefectProcessingArea { get; set; }
        /// <summary>
        /// Площадь уч.хранения Sскл.кр
        /// </summary>
        public double StockArea { get; set; }
        /// <summary>
        /// Площадь раскр. цеха Sраскр
        /// </summary>
        public double CuttingRoomArea { get; set; }
    }
}
