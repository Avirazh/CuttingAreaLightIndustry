using System.Collections.Generic;

namespace susProject.Model
{
    public class ResultGroup
    {
        public string Name { get; set; }
        public List<ResultLine> resultLines { get; set; }
        /// <summary>
        /// Фактическое количество рабочих
        /// </summary>
        public int ActualWorkersQuantity { get; set; }
        /// <summary>
        /// Количество оборудования К.об
        /// </summary>
        public int EquipmentAmount { get; set; }
        /// <summary>
        /// Коэффициент использования площади К.пл
        /// </summary>
        public double AreaUsageTotalRate { get; set; }
        /// <summary>
        /// Площадь участка S, м^2
        /// </summary>
        public double LandArea { get; set; }
    }
}
