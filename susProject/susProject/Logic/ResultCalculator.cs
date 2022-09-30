using System;
using System.Collections.Generic;
using susProject.Model;

namespace susProject.Logic
{
    public class ResultCalculator
    {
        public Workshop workshop;
        public List<Product> products;
        public List<Material> materials;
        private double ShiftDurByRate;
        public ResultCalculator(Workshop workshop,List<Product> products, List<Material> materials )
        {
            this.workshop = workshop;
            this.products = products;
            this.materials = materials;
            ShiftDurByRate = workshop.ShiftDuration * workshop.ShiftRate;
        }
        public Result Calculate()
        {
            Result result = new Result(workshop, products)
                ;
            CalcMaterialPreResult(result);
            CalcProductPreResult(result);
            workshop.CuttingRoomArea = CalcCuttingRoomArea(workshop);
            SetResult(result);

            return result;
        }
        private void SetResult(Result result)
        {
            result.defected.EstWorkersQuantity = 0;
            result.storage.EstWorkersQuantity = 0;

            result.lining.ActualWorkersQuantity = Convert.ToInt32(Math.Ceiling(result.lining.EstWorkersQuantity));
            result.cutting.ActualWorkersQuantity = Convert.ToInt32(Math.Ceiling(result.cutting.EstWorkersQuantity));
            result.labeling.ActualWorkersQuantity = Convert.ToInt32(Math.Ceiling(result.labeling.EstWorkersQuantity));
            result.storage.ActualWorkersQuantity = 1;
            result.duplicate.ActualWorkersQuantity = Convert.ToInt32(Math.Ceiling(result.duplicate.EstWorkersQuantity));
            result.defected.ActualWorkersQuantity = Convert.ToInt32(Math.Ceiling(0.1 * result.matCovering.EstWorkersQuantity));
            result.covering.ActualWorkersQuantity = 2 * result.covering.EquipmentAmount;
            result.processing.ActualWorkersQuantity = Convert.ToInt32(Math.Ceiling(result.processing.EstWorkersQuantity));

            result.lining.EquipmentAmount = result.covering.ActualWorkersQuantity;
            result.cutting.EquipmentAmount = result.cutting.ActualWorkersQuantity;
            result.labeling.EquipmentAmount = result.labeling.ActualWorkersQuantity;
            result.storage.EquipmentAmount = result.storage.ActualWorkersQuantity;
            result.duplicate.EquipmentAmount = result.duplicate.ActualWorkersQuantity;
            result.defected.EquipmentAmount = result.defected.ActualWorkersQuantity;
            result.processing.EquipmentAmount = result.processing.ActualWorkersQuantity;

            result.lining.AreaUsageTotalRate = workshop.WorkshopAreaUsageRate;
            result.cutting.AreaUsageTotalRate = workshop.WorkshopAreaUsageRate;
            result.labeling.AreaUsageTotalRate = workshop.WorkshopAreaUsageRate;
            result.storage.AreaUsageTotalRate = workshop.WorkshopAreaUsageRate;
            result.duplicate.AreaUsageTotalRate = workshop.WorkshopAreaUsageRate;
            result.defected.AreaUsageTotalRate = workshop.WorkshopAreaUsageRate;
            result.processing.AreaUsageTotalRate = workshop.WorkshopAreaUsageRate;
            result.covering.AreaUsageTotalRate = workshop.WorkshopAreaUsageRate;

            result.lining.LandArea = workshop.LiningArea;
            result.covering.LandArea = workshop.CoveringArea;
            result.cutting.LandArea = workshop.CuttingDetailsArea;
            result.processing.LandArea = workshop.CutProcessingArea;
            result.labeling.LandArea = workshop.BrandingArea;
            result.defected.LandArea = workshop.DefectProcessingArea;
            result.storage.LandArea = workshop.StockArea;
            result.duplicate.LandArea = workshop.DuplicationArea;
        }
        private double CalcCuttingRoomArea(Workshop w)
        {
            double areasSum = w.CuttingDetailsArea + w.CutProcessingArea + w.BrandingArea
                + w.DuplicationArea + w.DefectProcessingArea + w.StockArea;
            return areasSum + 0.15 * areasSum;
            
        }
        private void CalcMaterialPreResult(Result result)
        {
            double liningWorkersSum = 0;
            double coveringTableSum = 0;
            double cuttingDetailsAreaSum = 0;

            double defectProcessingAreaSum = 0;
            double stockAreaSum = 0;

            if (materials != null)
            {
                foreach (Material material in materials)
                {
                    if (material != null)
                    {
                        material.CutPacks = CalcCutPacks(material);
                        material.LiningAmount = CalcLiningAmount(material);
                        material.LiningWorkersAmount = CalcWorkersAmount(material);
                        material.DailyRequirement = CalcDailyRequirement(material);
                        material.CoveringTableAmount = CalcCoveringTableAmount(material);

                        material.CoveringWorkersAmount = CalcCoveringWorkers(material);
                        material.QualityWorkersAmount = CalcQualityWorkers(material); 
                        material.BrandingWorkersAmount = CalcBrandingWorkers(material);
                        material.CuttingWorkersAmount = CalcCuttingWorkers(material);
                        material.RemovalWorkersAmount = CalcRemovalWorkers(material);

                        material.CoveringSpaceWorkersAmount = CalcCoveringSpaceWorkers(material);
                        material.CuttingDetailsWorkersAmount = CalcCuttingDetailsWorkers(material);

                        liningWorkersSum += material.LiningWorkersAmount;
                        coveringTableSum += material.CoveringTableAmount;
                        cuttingDetailsAreaSum += material.CuttingDetailsWorkersAmount;
                        defectProcessingAreaSum += material.CoveringWorkersAmount;
                        stockAreaSum += material.CutPacks;

                        result.lining.EstWorkersQuantity += material.LiningWorkersAmount;
                        result.cutting.EstWorkersQuantity += material.CuttingDetailsWorkersAmount;

                        result.matCovering.EstWorkersQuantity += material.CoveringWorkersAmount;
                        result.qualityCheckCovering.EstWorkersQuantity += material.QualityWorkersAmount;
                        result.labelCovering.EstWorkersQuantity += material.BrandingWorkersAmount;
                        result.cutCovering.EstWorkersQuantity += material.CuttingWorkersAmount;
                        result.removeCovering.EstWorkersQuantity += material.RemovalWorkersAmount;

                    }
                }
                workshop.LiningArea = CalcLiningArea(liningWorkersSum);
                workshop.CoveringArea = CalcCoveringArea(coveringTableSum);
                workshop.CuttingDetailsArea = CalcCuttingDetailsArea(cuttingDetailsAreaSum);
                workshop.DefectProcessingArea = CalcDefectProcessingArea(defectProcessingAreaSum);
                workshop.StockArea = CalcStockArea(stockAreaSum);

                result.covering.EstWorkersQuantity = CalcEstCoveringWorkers(result);
                result.covering.EquipmentAmount = Convert.ToInt32(Math.Ceiling(coveringTableSum));
            }
        }      
        private void CalcProductPreResult(Result result)
        {
            double gatheringAreaSum = 0;
            double numeratingAreaSum = 0;
            double brandingAreaSum = 0;
            double duplicationAreaSum = 0;

            foreach(Product product in products)
            {
                product.QualityCheckAmount = CalcQualityCheckAmount(product);
                product.NumeratingAmount = CalcNumeratingAmount(product);
                product.BrandingAmount = CalcBrandingAmount(product);
                product.PreparationAreaAmount = CalcPreparationAreaAmount(product);

                gatheringAreaSum += product.QualityCheckAmount;
                numeratingAreaSum += product.NumeratingAmount;
                brandingAreaSum += product.BrandingAmount;
                duplicationAreaSum += product.PreparationAreaAmount;

                result.labeling.EstWorkersQuantity += product.BrandingAmount;
                result.duplicate.EstWorkersQuantity += product.PreparationAreaAmount;

            }
            workshop.GatheringArea = CalcGatheringArea(gatheringAreaSum);
            workshop.NumeratingArea = CalcNumeratingArea(numeratingAreaSum);
            workshop.CutProcessingArea = workshop.GatheringArea + workshop.NumeratingArea;

            workshop.BrandingArea = CalcBrandingArea(brandingAreaSum);
            workshop.DuplicationArea = CalcDuplicationArea(duplicationAreaSum);

            result.qualityCheckProcessing.EstWorkersQuantity = gatheringAreaSum;
            result.numeratingProcessing.EstWorkersQuantity = numeratingAreaSum;

            result.processing.EstWorkersQuantity = result.qualityCheckProcessing.EstWorkersQuantity + result.numeratingProcessing.EstWorkersQuantity;
        }

        private double CalcEstCoveringWorkers(Result result)
        {
            return (result.matCovering.EstWorkersQuantity + result.qualityCheckCovering.EstWorkersQuantity
                + result.labelCovering.EstWorkersQuantity + result.cutCovering.EstWorkersQuantity +
                result.removeCovering.EstWorkersQuantity);
        }

        private double CalcQualityCheckAmount(Product product)
        {
            return product.ProdReleaseAmount * product.QualityCheckTime / ShiftDurByRate;
        }     
        private double CalcNumeratingAmount(Product product)
        {
            return product.ProdReleaseAmount * product.NumerationTime / ShiftDurByRate;
        }
       
        private double CalcBrandingAmount(Product product)
        {
            return product.ProdReleaseAmount * product.LabelPrintTime / ShiftDurByRate;
        }
        private double CalcPreparationAreaAmount(Product product)
        {
            return product.ProdReleaseAmount * product.DetailsDuplicTime / ShiftDurByRate;
        }
        
        private double CalcGatheringArea(double sum)
        {
            return Math.Ceiling(sum) * workshop.QualityCheckTableArea / workshop.WorkshopAreaUsageRate;
        }
        private double CalcNumeratingArea(double sum)
        {
            return Math.Ceiling(sum) * workshop.NumerationEquipmentArea / workshop.WorkshopAreaUsageRate;
        }
        private double CalcBrandingArea(double sum)
        {
            return Math.Ceiling(sum) * workshop.LabelMachineArea / workshop.WorkshopAreaUsageRate;
        }
        private double CalcDuplicationArea(double sum)
        {
            return Math.Ceiling(sum) * workshop.DuplicationPressArea / workshop.WorkshopAreaUsageRate;
        }
        private double CalcDefectProcessingArea(double sum)
        {
            return Math.Ceiling(0.1 * Math.Ceiling(sum)) * workshop.TableArea / workshop.WorkshopAreaUsageRate; 
        }
        private double CalcStockArea(double sum)
        {
            return (workshop.ShelfSize * workshop.CuttingStock * sum) / 
                (workshop.LayerHeight * workshop.CuttingPacksInOneCell * workshop.WorkshopAreaUsageRate);
        }
        private double CalcLiningArea(double sum)
        {
            return (Math.Ceiling(sum) * workshop.TableArea + workshop.LiningEquipmentArea) / workshop.WorkshopAreaUsageRate;
        }
        private double CalcCoveringArea(double sum)
        {
            return (Math.Ceiling(sum) * workshop.TableArea + workshop.CoveringEquipmentArea) / workshop.WorkshopAreaUsageRate;
        }
        private double CalcCuttingDetailsArea(double sum)
        {
            return (Math.Ceiling(sum) * workshop.CuttingMachineArea + workshop.CuttingEquipmentArea) / workshop.WorkshopAreaUsageRate;
        }

        private double CalcCutPacks(Material material)
        {
            return material.CoveringHeight * workshop.LiningCoeff / material.Product.ProdReleaseAmount;
        }
        private double CalcLiningAmount(Material material)
        {
            return material.LiningAmount = material.CutPacks / workshop.LiningCompleteneAmount;
        }
        private double CalcWorkersAmount(Material material)
        {
            return (material.LiningWorkersAmount = material.LiningsTime * workshop.LiningCompleteneAmount) / ShiftDurByRate;;
        }
        private double CalcDailyRequirement(Material material)
        {
            return material.ConsumptionRate / 1.5 * material.Product.ProdReleaseAmount;
        }
        private double CalcCoveringTableAmount(Material material)
        {
            return (material.DailyRequirement / workshop.FabricProdRate) + 
                (material.CutPacks *
                (material.CoveringQualityCheckTime + material.CoveringBrandingTime + material.CoveringCuttingTime + material.CoveringRemovalTime)/
                workshop.ShiftDuration);
        }
        private double CalcCoveringWorkers(Material material)
        {
            return (material.DailyRequirement * material.MaterialCoveringTime) / ShiftDurByRate;
        }
        private double CalcQualityWorkers(Material material)
        {
            return (material.CutPacks * material.CoveringQualityCheckTime)/ ShiftDurByRate;  
        }
        private double CalcBrandingWorkers(Material material)
        {
            return (material.CutPacks * material.CoveringBrandingTime) / ShiftDurByRate;
        }
        private double CalcCuttingWorkers(Material material)
        {
            return (material.CutPacks * material.CoveringQualityCheckTime)/ ShiftDurByRate;
        }
        private double CalcRemovalWorkers(Material material)
        {
            return (material.CutPacks * material.CoveringRemovalTime)/ ShiftDurByRate;
        }
        private double CalcCoveringSpaceWorkers(Material material)
        {
            return material.CoveringWorkersAmount + material.QualityWorkersAmount
                + material.BrandingWorkersAmount + material.CuttingWorkersAmount + material.RemovalWorkersAmount;
        }
        private double CalcCuttingDetailsWorkers(Material material)
        {
            return (material.CutPacks * material.DetailsCuttingTime) / ShiftDurByRate;
        }

    }
}
