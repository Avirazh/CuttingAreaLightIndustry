using System.Collections.Generic;

namespace susProject.Model
{
    public class Result
    {
        private Workshop workshop;
        private List<Product> products;
        public List<ResultGroup> Groups;
        
        public OneLineGroup lining = new OneLineGroup();
        public OneLineGroup cutting = new OneLineGroup();
        public OneLineGroup labeling = new OneLineGroup();
        public OneLineGroup defected = new OneLineGroup();
        public OneLineGroup storage = new OneLineGroup();
        public OneLineGroup duplicate = new OneLineGroup();

        public ResultGroup covering = new ResultGroup();
        public ResultLine matCovering = new ResultLine();
        public ResultLine qualityCheckCovering = new ResultLine();
        public ResultLine labelCovering = new ResultLine();
        public ResultLine cutCovering = new ResultLine();
        public ResultLine removeCovering = new ResultLine();

        public ResultGroup processing = new ResultGroup();
        public ResultLine qualityCheckProcessing = new ResultLine();
        public ResultLine numeratingProcessing = new ResultLine();
        public Result(Workshop workshop, List<Product> products)
        {
            this.workshop = workshop;
            this.products = products;

            covering.resultLines.Add(matCovering);
            covering.resultLines.Add(qualityCheckCovering);
            covering.resultLines.Add(labelCovering);
            covering.resultLines.Add(cutCovering);
            covering.resultLines.Add(removeCovering);

            processing.resultLines.Add(qualityCheckProcessing);
            processing.resultLines.Add(numeratingProcessing);
        }

    }
}
