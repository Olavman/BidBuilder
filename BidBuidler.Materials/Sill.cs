using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BidBuidler.Components
{
  public class Sill : ModuleComponent
  {
    public string MaterialType { get; set; }
    double ThicknessMm { get; set; }

    public Sill(string name, string materialType, double lengthMm, double depthMm, double widthMm, double thicknessMm)
    {
      Name = name;
      MaterialType = materialType;
      HeightMm = lengthMm;
      DepthMm = depthMm;
      WidthMm = widthMm;
      ThicknessMm = thicknessMm;
    }
  }
}
