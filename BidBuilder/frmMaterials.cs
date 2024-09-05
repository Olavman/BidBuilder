using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BidBuidler.Components;
using BidBuidler.Materials;

namespace BidBuilder
{
  public partial class frmMaterials : Form
  {
    private System.Windows.Forms.Timer debounceTimer = new System.Windows.Forms.Timer();
    public List<ModuleComponent> Materials { get; set; }
    public frmMaterials()
    {
      InitializeComponent();
      PopulateMaterialTypeComboBox();
      Materials = GetMaterials();
      debounceTimer.Interval = 10; // Delay in milliseconds
      debounceTimer.Tick += DebounceTimer_Tick;

      textBoxName.TextChanged += TextBoxes_TextChanged;
      comboBoxMaterialType.TextChanged += TextBoxes_TextChanged;
      textBoxLength.TextChanged += TextBoxes_TextChanged;
      textBoxDepth.TextChanged += TextBoxes_TextChanged;
      textBoxWidth.TextChanged += TextBoxes_TextChanged;
      textBoxPrice.TextChanged += TextBoxes_TextChanged;
      textBoxUnitType.TextChanged += TextBoxes_TextChanged;
      textBoxCutMinutes.TextChanged += TextBoxes_TextChanged;

      // Select the top row to load all textboxes with values
      //dataGridViewMaterials.
    }

    private void PopulateMaterialTypeComboBox()
    {
      comboBoxMaterialType.DataSource = Enum.GetValues(typeof(ConstructionMaterial));
      comboBoxMaterialType.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    private List<ModuleComponent> GetMaterials()
    {
      var list = new List<ModuleComponent>();
      list.Add(new Stud()
        {

          Name = "C+ 70mm 3,6m 0,46mm",
          MaterialType = ConstructionMaterial.Steel,
          HeightMm = 3600,
          DepthMm = 70,
          WidthMm = 36,
          Price = 46.32,
          UnitType = "stk"
        }
      );
      list.Add(new Stud()
        {
          Name = "C+ 70mm 3,0m 0,46mm",
          MaterialType = ConstructionMaterial.Steel,
          HeightMm = 3000,
          DepthMm = 70,
          WidthMm = 36,
          Price = 46.32,
          UnitType = "stk"
        }
      );
      list.Add(new Stud()
        {

          Name = "48x98 gran 4,2m",
          MaterialType = ConstructionMaterial.Wood,
          HeightMm = 4200,
          DepthMm = 98,
          WidthMm = 48,
          Price = 46.32,
          UnitType = "stk"
        }
      );

      return list;
    }

    private void frmMaterials_Load(object sender, EventArgs e)
    {
      var materials = this.Materials;
      dataGridViewMaterials.DataSource = materials;
      dataGridViewMaterials.AutoGenerateColumns = false;
      HideColumnsInDataGridView();
      UpdateTextboxData();
    }

    private void HideColumnsInDataGridView()
    {
      if (dataGridViewMaterials.Columns.Count > 0)
      {
        foreach (DataGridViewColumn column in dataGridViewMaterials.Columns)
        {
          if (column.Name != "Name")
          {
            column.Visible = false;
          }
          else
          {
            column.Width = dataGridViewMaterials.Width-1;
          }
        }
      }
    }

    private void btnEditMaterial_Click(object sender, EventArgs e)
    {

    }

    private void dataGridViewMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      UpdateTextboxData();
    }

    private void UpdateTextboxData()
    {
      if (dataGridViewMaterials.RowCount > 0)
      {

        try
        {
          var selectedMaterial = dataGridViewMaterials.SelectedRows[0].DataBoundItem as ModuleComponent;
          textBoxName.Text = selectedMaterial.Name.ToString();
          comboBoxMaterialType.Text = selectedMaterial.MaterialType.ToString();
          textBoxLength.Text = selectedMaterial.HeightMm.ToString();
          textBoxDepth.Text = selectedMaterial.DepthMm.ToString();
          textBoxWidth.Text = selectedMaterial.WidthMm.ToString();
          textBoxPrice.Text = selectedMaterial.Price.ToString();
          textBoxUnitType.Text = selectedMaterial.UnitType.ToString();
          textBoxCutMinutes.Text = selectedMaterial.CutMinute.ToString();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Some error occured: " + ex.Message + " - " + ex.Source);
        }
      }

    }

    private void TextBoxes_TextChanged(object sender, EventArgs e)
    {
      // Restart the debounce timer whenever text changes
      debounceTimer.Stop(); // Stop the previous timer
      debounceTimer.Start(); // Restart the timer
    }

    private void DebounceTimer_Tick(object sender, EventArgs e)
    {
      debounceTimer.Stop(); // Stop the timer
      UpdateMaterialProperties(); // Execute updated material calculations
    }

    private void UpdateMaterialProperties()
    {
      var material = dataGridViewMaterials.SelectedRows[0].DataBoundItem as ModuleComponent;
      if(material != null)
      {
        double length, depth, width, price;
        if (double.TryParse(textBoxLength.Text, out length))
          material.HeightMm = length;
        if (double.TryParse(textBoxDepth.Text, out depth))
          material.DepthMm = depth;
        if (double.TryParse(textBoxWidth.Text, out width))
          material.WidthMm = width;
        if (double.TryParse(textBoxPrice.Text, out price))
          material.Price = price;

        material.Name = textBoxName.Text;
        material.MaterialType = (ConstructionMaterial)Enum.Parse(typeof(ConstructionMaterial), comboBoxMaterialType.Text);
      }

      material.CutMinute = Calculations.CalculateCutSpeed(material);
      dataGridViewMaterials.Refresh();
      UpdateTextboxData();
    }

    private void btnNewMaterial_Click(object sender, EventArgs e)
    {
      AddNewMaterial();
    }

    private void AddNewMaterial()
    {
      using (var form = new frmNewMaterial())
      {
        if (form.ShowDialog() == DialogResult.OK)
        {
          var newMaterial = form.CreatedMaterial;
          if (newMaterial != null)
          {
            DebugUtility.DebugMessage("Material added");
            Materials.Add(newMaterial);
            UpdateMaterialList();
            UpdateTextboxData();
          }
        }
      }
    }

    private void UpdateMaterialList()
    {
      dataGridViewMaterials.DataSource = null;
      dataGridViewMaterials.DataSource = Materials;
    }

    private void btnDeleteMaterial_Click(object sender, EventArgs e)
    {
      // Check if any rows are selected
      if (dataGridViewMaterials.SelectedRows.Count > 0)
      {
        // Get the selected material
        var selectedMaterial = dataGridViewMaterials.SelectedRows[0].DataBoundItem as ModuleComponent;
        if (selectedMaterial != null)
        {
          // Remove the selected material
          Materials.Remove(selectedMaterial);

          // Refresh the DataGridView to show the updated list
          UpdateMaterialList();
          UpdateTextboxData();
        }
      }
      else
      {
        MessageBox.Show("No material selected. Please select a material to delete.");
      }
    }
  }
}
