namespace BidBuilder
{
  partial class frmNewMaterial
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.comboBoxModuleComponentTypes = new System.Windows.Forms.ComboBox();
      this.btnCreate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // comboBoxModuleComponentTypes
      // 
      this.comboBoxModuleComponentTypes.FormattingEnabled = true;
      this.comboBoxModuleComponentTypes.Location = new System.Drawing.Point(193, 121);
      this.comboBoxModuleComponentTypes.Name = "comboBoxModuleComponentTypes";
      this.comboBoxModuleComponentTypes.Size = new System.Drawing.Size(121, 21);
      this.comboBoxModuleComponentTypes.TabIndex = 0;
      // 
      // btnCreate
      // 
      this.btnCreate.Location = new System.Drawing.Point(193, 171);
      this.btnCreate.Name = "btnCreate";
      this.btnCreate.Size = new System.Drawing.Size(108, 23);
      this.btnCreate.TabIndex = 1;
      this.btnCreate.Text = "Create material";
      this.btnCreate.UseVisualStyleBackColor = true;
      this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
      // 
      // frmNewMaterial
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnCreate);
      this.Controls.Add(this.comboBoxModuleComponentTypes);
      this.Name = "frmNewMaterial";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.frmNewMaterial_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBoxModuleComponentTypes;
    private System.Windows.Forms.Button btnCreate;
  }
}