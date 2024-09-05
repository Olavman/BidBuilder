using BidBuidler.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidBuidler.Components
{
  public abstract class ModuleComponent
  {
    public double Weight { get; set; }
    public string Name { get; set; }
    public double HeightMm { get; set; }
    public double WidthMm { get; set; }
    public double DepthMm { get; set; }
    public double ThicknessMm { get; set; }
    public double Price {  get; set; }
    public string UnitType { get; set; }
    public ConstructionMaterial MaterialType { get; set; }
    public double CutMinute { get; set; }


    public ModuleComponent()
    {
      this.Weight = Calculations.CalculateWeight(MaterialType, HeightMm, WidthMm, DepthMm);
    }

  }
}
