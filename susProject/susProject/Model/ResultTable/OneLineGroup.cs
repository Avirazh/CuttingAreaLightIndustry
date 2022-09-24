using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susProject.Model.ResultTable
{
    public class OneLineGroup : IGroup
    {
        public string Name { get; set; }

        public double EstWorkersQuantity { get; set; }
        public int ActualWorkersQuantity { get; set; }
        public int EquipmentAmount { get; set; }
        public double AreaUsageTotalRate { get; set; }
        public double LandArea { get; set; }

    }
}
