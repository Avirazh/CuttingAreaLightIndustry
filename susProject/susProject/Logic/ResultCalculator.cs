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
        public ResultCalculator(Workshop workshop,List<Product> products, List<Material> materials )
        {
            this.workshop = workshop;
            this.products = products;
            this.materials = materials;
        }
        public Result Calculate()
        {
            Result result = new Result(workshop, products);
            //calculation methods
            return result;
        }

        public List<ResultGroup> SetResultGroups()
        {
            List<ResultGroup> resultGroups = new List<ResultGroup>();

                        

            return resultGroups;
        }
        public void CalcMaterialSemiResult()
        {
            double liningWorkersSum = 0;
            double coveringTableSum = 0;
            foreach(Material material in materials)
            {
                material.CutPacks = CalcCutPacks(material);
                material.LiningAmount = CalcLiningAmount(material);
                material.LiningWorkersAmount = CalcWorkersAmount(material);
                material.DailyRequirement = CalcDailyRequirement(material);
                material.CoveringTableAmount = CalcCoveringTableAmount(material);

                liningWorkersSum+= material.LiningWorkersAmount;
                coveringTableSum += material.CoveringTableAmount;
            }
            workshop.LiningArea = CalcLiningArea(liningWorkersSum);
            workshop.CoveringArea = CalcCoveringArea(coveringTableSum);
        }
        public double CalcCutPacks(Material material)
        {
            return material.CoveringHeight * workshop.LiningCoeff / material.Product.ProdReleaseAmount;
        }
        public double CalcLiningAmount(Material material)
        {
            return material.LiningAmount = material.CutPacks / workshop.LiningCompleteneAmount;
        }
        public double CalcWorkersAmount(Material material)
        {
            return (material.LiningWorkersAmount = material.LiningsTime * workshop.LiningCompleteneAmount) / workshop.ShiftDuration * workshop.ShiftRate;
        }
        public double CalcLiningArea(double sum)
        {
            return (Math.Ceiling(sum) * workshop.TableArea + workshop.LiningEquipmentArea) / workshop.WorkshopAreaUsageRate;
        }
        public double CalcDailyRequirement(Material material)
        {
            return material.ConsumptionRate / 1.5 * material.Product.ProdReleaseAmount;
        }
        public double CalcCoveringTableAmount(Material material)
        {
            return (material.DailyRequirement / workshop.FabricProdRate) + 
                (material.CutPacks *
                (material.CoveringQualityCheckTime + material.CoveringBrandingTime + material.CoveringCuttingTime + material.CoveringRemovalTime)/
                workshop.ShiftDuration);
        }
        public double CalcCoveringArea(double sum)
        {
            return (Math.Ceiling(sum) * workshop.TableArea + workshop.CoveringEquipmentArea) / workshop.WorkshopAreaUsageRate;
        }
    }
}
