using System.Collections.Generic;

namespace susProject.Model
{
    public class Result
    {
        private Workshop workshop;
        private List<Product> products;
        public List<ResultGroup> Groups;
        public Result(Workshop workshop, List<Product> products)
        {
            this.workshop = workshop;
            this.products = products;
        }

    }
}
