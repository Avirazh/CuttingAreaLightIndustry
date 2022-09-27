using System.Collections.Generic;

namespace susProject.Model
{
    public class ResultGroup : IGroup
    {
        public string Name { get; set; }

        /// <summary>
        /// Расчетное количество рабочих
        /// </summary>
        public double EstWorkersQuantity { get; set; }
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
        public List<ResultLine> resultLines { get; set; }
    }
}
