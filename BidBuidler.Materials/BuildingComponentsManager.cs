using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using BidBuidler.Components;

namespace BidBuidler.Materials
{
  public class BuildingComponentsManager
  {
    private const string filePath = "BuildingComponents.json";

    public static void SaveComponents(List<ModuleComponent> components)
    {
      string json = JsonConvert.SerializeObject(components, Formatting.Indented);
      File.WriteAllText(filePath, json);
    }

    public static List<ModuleComponent> LoadComponents()
    {
      if (File.Exists(filePath))
      {
        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<ModuleComponent>>(json);
      }
      return new List<ModuleComponent>();
    }

  }
}
