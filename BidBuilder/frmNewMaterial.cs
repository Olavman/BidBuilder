using BidBuidler.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace BidBuilder
{
  public partial class frmNewMaterial : Form
  {
    public ModuleComponent CreatedMaterial { get; private set; }
    public frmNewMaterial()
    {
      InitializeComponent();
      PopulateComponentTypeDropDown();
    }

    private void PopulateComponentTypeDropDown()
    {
      comboBoxModuleComponentTypes.Items.Clear();

      // Get all types in the assembly that are subclasses of ModuleComponent
      var componentTypes = Assembly.GetAssembly(typeof(ModuleComponent)).GetTypes()
        .Where(t => t.IsSubclassOf(typeof(ModuleComponent)) && !t.IsAbstract);

      foreach (var type in componentTypes)
      {
        comboBoxModuleComponentTypes.Items.Add(type);
      }

      // Setting the DisplayMember to "Name" assumes you want to show the class name. Adjust if needed
      comboBoxModuleComponentTypes.DisplayMember = "Name";
    }

    private void frmNewMaterial_Load(object sender, EventArgs e)
    {

    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
      Type selectedType = comboBoxModuleComponentTypes.SelectedItem as Type;
      if (selectedType != null)
      {
        CreatedMaterial = Activator.CreateInstance(selectedType) as ModuleComponent;

        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }
  }
}
