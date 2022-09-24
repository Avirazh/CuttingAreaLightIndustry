using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using susProject.Model;

namespace susProject.Logic
{
    public class ResultCalculator
    {
        public Workshop workshop;
        public List<Product> products;
        public ResultCalculator(Workshop workshop,List<Product> products )
        {
            this.workshop = workshop;
            this.products = products;
        }
        public Result Calculate()
        {
            Result result = new Result(workshop, products);
            return result;
        }
    }
}
