using System;
using System.Collections.Generic;
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

        public List<ResultGroup> SetResultGroups()
        {
            List<ResultGroup> resultGroups = new List<ResultGroup>();
            ResultGroup lining = new ResultGroup();
            ResultGroup covering = new ResultGroup();
            ResultGroup cutting = new ResultGroup();
            ResultGroup processing = new ResultGroup();
            ResultGroup labeling = new ResultGroup();
            return resultGroups;
        }

    }
}
