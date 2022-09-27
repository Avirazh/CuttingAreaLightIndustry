using System.Collections.Generic;

namespace susProject.Model
{
    public class Result
    {
        private Workshop workshop;
        private List<Product> products;
        public List<ResultGroup> Groups;

        /// <summary>
        /// Обмеловка, обмеловочный участок
        /// </summary>
        public OneLineGroup lining = new OneLineGroup();
        /// <summary>
        /// Участок вырезания деталей кроя
        /// </summary>
        public OneLineGroup cutting = new OneLineGroup();
        /// <summary>
        /// Участок печатания ярлыков и оформление документации
        /// </summary>
        public OneLineGroup labeling = new OneLineGroup();
        /// <summary>
        /// Участок обработки дефектных полотен
        /// </summary>
        public OneLineGroup defected = new OneLineGroup();
        /// <summary>
        /// Участок хранения хранения кроя
        /// </summary>
        public OneLineGroup storage = new OneLineGroup();
        /// <summary>
        /// Участок предварительной подготовки кроя Дублирование
        /// </summary>
        public OneLineGroup duplicate = new OneLineGroup();

        /// <summary>
        /// Настилочный участок:
        /// </summary>
        public ResultGroup covering = new ResultGroup();
        /// <summary>
        /// - настилание материала
        /// </summary>
        public ResultLine matCovering = new ResultLine();
        /// <summary>
        /// -контроль качества продукции
        /// </summary>
        public ResultLine qualityCheckCovering = new ResultLine();
        /// <summary>
        /// -клеймение настила
        /// </summary>
        public ResultLine labelCovering = new ResultLine();
        /// <summary>
        /// -рассекание настила
        /// </summary>
        public ResultLine cutCovering = new ResultLine();
        /// <summary>
        /// '-съем настил
        /// </summary>
        public ResultLine removeCovering = new ResultLine();

        /// <summary>
        /// Участок обработки кроя
        /// </summary>
        public ResultGroup processing = new ResultGroup();
        /// <summary>
        /// -проверка качества
        /// </summary>
        public ResultLine qualityCheckProcessing = new ResultLine();
        /// <summary>
        /// -нумерация
        /// </summary>
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
