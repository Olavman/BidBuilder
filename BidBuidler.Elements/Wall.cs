using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using BidBuidler.Components;
using BidBuidler.Modules;

namespace BidBuidler.Modules
{
  public class Wall : Module
  {
    public double LengthM {  get; set; }
    public double HeightM { get; set; }
    public int WallCount { get; set; }
    public int Openings { get; set; }
    public double CcM { get; set; }
    public Stud StudType {  get; set; }
    public Sill SillType {  get; set; }
    public Insulation InsulationType { get; set; }
    public Plate PlateType { get; set; }
    public Wall(string name, double lengthM, double heightM, int wallCount, int openings, int ccM) 
    { 
      Name = name;
      LengthM = lengthM;
      HeightM = heightM;
      WallCount = wallCount;
      Openings = openings;
      CcM = ccM;
    }

    public int CalculateStudCount()
    {
      double averageWallLength = LengthM / WallCount;
      int count = (int) (WallCount + Openings + Math.Ceiling(averageWallLength / CcM));

      return count;
    }

    public double CalculateStudAmount()
    {
      double studH = Calculations.ConvertMmToM(StudType.HeightMm);
      double wallH = HeightM;
      double studsPrCc = 0;
      double studAmount = 0;

      // If the stud is higher than the wall, check to see how many full wall heights fall into a stud height
      // If the wall is higher than the stud, calculate the remaining height of the wall after filling in with studs, then check to see how many heights of the remaining fall into a stud height
      if(studH >= wallH)
      {
        studsPrCc = 1/Math.Floor(studH / wallH); // Scenario studH = 3.0, wallH = 0.7, studsPrCc = 0.25
      }
      else
      {
        double overlapM = 0.4;
        double remaining = wallH % studH + overlapM; // Scenario studH = 3.0, wallH = 3.4, remaining = 0.8
        studsPrCc = Math.Floor(wallH / studH) + (1/Math.Floor(studH / remaining)); // Scenario studH = 3.0, wallH = 3.4, studsPrCc = (1) + (0.333) = 1.333
      }

      studAmount = Math.Ceiling(studsPrCc * CalculateStudCount()); // Scenario studsPrCc = 1.333, calculateStudCount = 10, studAmount = 14

      return studAmount;
    }



  }
}
