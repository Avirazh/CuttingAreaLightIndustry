using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using susProject.Model;

namespace susProject.Logic
{
    public class Test
    {
        Workshop workshop = new Workshop();

        Product productOne = new Product();
        Product productTwo = new Product();

        List<Product> products = new List<Product>();
        List<Material> materials = new List<Material>();

        Material materialOne = new Material();
        Material materialTwo = new Material();
        public Test()
        {
            materials.Add(materialOne);
            materials.Add(materialTwo);

            SetWorkshop(workshop);
            productOne.AddMaterial(materialOne);
            SetProduct(productOne);
            SetMaterial(materialOne, productOne);
            ResultCalculator testcalc = new ResultCalculator(workshop, products, materials);
            testcalc.Calculate();
        }
        public void SetWorkshop(Workshop workshop)
        {
            workshop.Name = "work1";
            workshop.ClericalTableArea = 1;
            workshop.CuttingEquipmentArea = 1;
            workshop.CuttingMachineArea = 1;
            workshop.CuttingPacksInOneCell = 1;
            workshop.CuttingStock = 1;
            workshop.DuplicationPressArea = 1;
            workshop.DuplicationSpaceUsageRate = 1;
            workshop.ShiftDuration = 1;
            workshop.ShiftRate = 1; 
            workshop.ShelfSize = 1;
            workshop.FabricProdRate = 1;
            workshop.LabelMachineArea = 1;
            workshop.LayerHeight = 1;
            workshop.CoveringEquipmentArea = 1;
            workshop.LiningCoeff = 1;
            workshop.LiningCompleteneAmount = 1;
            workshop.LiningEquipmentArea = 1;
            workshop.NumerationEquipmentArea = 1;
            workshop.QualityCheckTableArea = 1;
            workshop.TableArea = 1;
            workshop.WorkshopAreaUsageRate = 1;
        }
        public void SetProduct(Product product)
        {
            product.Name = "prod";
            product.LabelPrintTime = 1;
            product.NumerationTime = 1;
            product.QualityCheckTime = 1;
            product.DetailsDuplicTime = 1;
            product.ProdReleaseAmount = 1;
            
        }
        public void SetMaterial(Material material, Product product)
        {
            material.Name = "mat";
            material.MaterialCoveringTime = 1;
            material.PatternContoursTime = 1;
            material.CoveringQualityCheckTime = 1;
            material.CoveringCuttingTime = 1;
            material.CoveringBrandingTime = 1;
            material.LiningsTime = 1;
            material.ConsumptionRate = 1;
            material.CoveringRemovalTime = 1;
            material.CoveringHeight = 1;
            material.DetailsCuttingTime = 1;
            material.Product = product;
        }
    }
}
