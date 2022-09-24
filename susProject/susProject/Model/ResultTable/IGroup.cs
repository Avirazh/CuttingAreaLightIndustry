using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susProject.Model
{
    public interface IGroup
    {
        string Name { get; set; }
        /// <summary>
        /// Фактическое количество рабочих
        /// </summary>
        int ActualWorkersQuantity { get; set; }
        /// <summary>
        /// Количество оборудования К.об
        /// </summary>
        int EquipmentAmount { get; set; }
        /// <summary>
        /// Коэффициент использования площади К.пл
        /// </summary>
        double AreaUsageTotalRate { get; set; }
        /// <summary>
        /// Площадь участка S, м^2
        /// </summary>
        double LandArea { get; set; }
    }
}
