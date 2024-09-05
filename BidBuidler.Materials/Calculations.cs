using BidBuidler.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidBuidler.Components
{
  public static class Calculations
  {
    public static double ConvertMmToM(double mm)
    {
      return mm / 1000;
    }

    public static double GetMaterialCubicWeight(ConstructionMaterial material)
    {
      switch (material)
      {
        case ConstructionMaterial.Steel:
          return 7850;
        case ConstructionMaterial.Aluminum:
          return 2750;
        case ConstructionMaterial.Wood:
          return 388.3;
        case ConstructionMaterial.Drywall:
          return 736;
        case ConstructionMaterial.HardDrywall:
          return 976;
        case ConstructionMaterial.Glass:
          return 2500;
        case ConstructionMaterial.Glassfiber:
          return 17.383;
        case ConstructionMaterial.Rockwool:
          return 28.970;
        default:
          return 0;
      }
    }

    public static double CalculateWeight (ConstructionMaterial material, double heightMm, double widthMm, double depthMm, double thicknessMm = 0) 
    {
      double area;
      double height = ConvertMmToM (heightMm);
      double width = ConvertMmToM (widthMm);
      double depth = ConvertMmToM (depthMm);
      double thickness = ConvertMmToM (thicknessMm);

      if (material == ConstructionMaterial.Steel || material == ConstructionMaterial.Aluminum) 
      {
        // Calculates the area of a U-shape
        area = (width * 2 + depth) * thickness;
      }
      else
      {
        area = width * depth;
      }

      double volume = area * height;
      double weight = volume * GetMaterialCubicWeight (material);

      return weight;
    }

    public static double CalculateWalkSpeed (double weight)
    {
      const double baseSpeed = 55; // Meters per minute (3.3km pr hour)

      //Calculate speed reduction based on weight
      double speedReductionFactor = Math.Pow(0.5, weight / 25);
      double speed = baseSpeed * speedReductionFactor;

      return speed;
    }

    public static double GetMaterialCutFactor(ConstructionMaterial material)
    {
      switch (material)
      {
        case ConstructionMaterial.Steel:
          return 2.0;
        case ConstructionMaterial.Aluminum:
          return 1.3;
        case ConstructionMaterial.Drywall:
          return 0.5;
        default:
          return 1;
      }
    }

    public static double CalculateCutSpeed (ModuleComponent component)
    {
      double sizeFactor = 0.05; // Time in minutes to cut one meter of material
      double materialCutFactor = GetMaterialCutFactor(component.MaterialType);

      double totalSize = ConvertMmToM(component.DepthMm * (1+component.ThicknessMm));
      double cuttingTime = sizeFactor * totalSize * materialCutFactor;

      return cuttingTime;
    }
  }
}
