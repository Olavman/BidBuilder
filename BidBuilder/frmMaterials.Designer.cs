namespace BidBuilder
{
  partial class frmMaterials
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnNewMaterial = new System.Windows.Forms.Button();
      this.btnDeleteMaterial = new System.Windows.Forms.Button();
      this.btnCopyMaterial = new System.Windows.Forms.Button();
      this.dataGridViewMaterials = new System.Windows.Forms.DataGridView();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.textBoxLength = new System.Windows.Forms.TextBox();
      this.textBoxWidth = new System.Windows.Forms.TextBox();
      this.textBoxDepth = new System.Windows.Forms.TextBox();
      this.textBoxPrice = new System.Windows.Forms.TextBox();
      this.textBoxUnitType = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.textBoxCutMinutes = new System.Windows.Forms.TextBox();
      this.comboBoxMaterialType = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).BeginInit();
      this.SuspendLayout();
      // 
      // btnNewMaterial
      // 
      this.btnNewMaterial.Location = new System.Drawing.Point(12, 642);
      this.btnNewMaterial.Name = "btnNewMaterial";
      this.btnNewMaterial.Size = new System.Drawing.Size(125, 33);
      this.btnNewMaterial.TabIndex = 1;
      this.btnNewMaterial.Text = "New material";
      this.btnNewMaterial.UseVisualStyleBackColor = true;
      this.btnNewMaterial.Click += new System.EventHandler(this.btnNewMaterial_Click);
      // 
      // btnDeleteMaterial
      // 
      this.btnDeleteMaterial.Location = new System.Drawing.Point(143, 642);
      this.btnDeleteMaterial.Name = "btnDeleteMaterial";
      this.btnDeleteMaterial.Size = new System.Drawing.Size(104, 33);
      this.btnDeleteMaterial.TabIndex = 2;
      this.btnDeleteMaterial.Text = "Delete material";
      this.btnDeleteMaterial.UseVisualStyleBackColor = true;
      this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
      // 
      // btnCopyMaterial
      // 
      this.btnCopyMaterial.Location = new System.Drawing.Point(253, 642);
      this.btnCopyMaterial.Name = "btnCopyMaterial";
      this.btnCopyMaterial.Size = new System.Drawing.Size(101, 33);
      this.btnCopyMaterial.TabIndex = 3;
      this.btnCopyMaterial.Text = "Copy material";
      this.btnCopyMaterial.UseVisualStyleBackColor = true;
      // 
      // dataGridViewMaterials
      // 
      this.dataGridViewMaterials.AllowUserToResizeColumns = false;
      this.dataGridViewMaterials.AllowUserToResizeRows = false;
      this.dataGridViewMaterials.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.dataGridViewMaterials.BorderStyle = System.Windows.Forms.BorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridViewMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dataGridViewMaterials.ColumnHeadersVisible = false;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(9)))), ((int)(((byte)(23)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewMaterials.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridViewMaterials.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.dataGridViewMaterials.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.dataGridViewMaterials.Location = new System.Drawing.Point(11, 12);
      this.dataGridViewMaterials.Name = "dataGridViewMaterials";
      this.dataGridViewMaterials.ReadOnly = true;
      this.dataGridViewMaterials.RowHeadersVisible = false;
      this.dataGridViewMaterials.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dataGridViewMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewMaterials.Size = new System.Drawing.Size(235, 624);
      this.dataGridViewMaterials.TabIndex = 5;
      this.dataGridViewMaterials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterials_CellClick);
      // 
      // textBoxName
      // 
      this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.textBoxName.Location = new System.Drawing.Point(409, 14);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(234, 22);
      this.textBoxName.TabIndex = 6;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.label1.Location = new System.Drawing.Point(252, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 24);
      this.label1.TabIndex = 7;
      this.label1.Text = "Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.label2.Location = new System.Drawing.Point(252, 126);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(115, 24);
      this.label2.TabIndex = 7;
      this.label2.Text = "Material type";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.label3.Location = new System.Drawing.Point(252, 42);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 24);
      this.label3.TabIndex = 7;
      this.label3.Text = "Length";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.label4.Location = new System.Drawing.Point(252, 70);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(58, 24);
      this.label4.TabIndex = 7;
      this.label4.Text = "Width";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.label5.Location = new System.Drawing.Point(252, 98);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(60, 24);
      this.label5.TabIndex = 7;
      this.label5.Text = "Depth";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.label6.Location = new System.Drawing.Point(252, 182);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(53, 24);
      this.label6.TabIndex = 7;
      this.label6.Text = "Price";
      // 
      // textBoxLength
      // 
      this.textBoxLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.textBoxLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.textBoxLength.Location = new System.Drawing.Point(409, 42);
      this.textBoxLength.Name = "textBoxLength";
      this.textBoxLength.Size = new System.Drawing.Size(234, 22);
      this.textBoxLength.TabIndex = 6;
      // 
      // textBoxWidth
      // 
      this.textBoxWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.textBoxWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.textBoxWidth.Location = new System.Drawing.Point(409, 70);
      this.textBoxWidth.Name = "textBoxWidth";
      this.textBoxWidth.Size = new System.Drawing.Size(234, 22);
      this.textBoxWidth.TabIndex = 6;
      // 
      // textBoxDepth
      // 
      this.textBoxDepth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.textBoxDepth.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxDepth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.textBoxDepth.Location = new System.Drawing.Point(409, 98);
      this.textBoxDepth.Name = "textBoxDepth";
      this.textBoxDepth.Size = new System.Drawing.Size(234, 22);
      this.textBoxDepth.TabIndex = 6;
      // 
      // textBoxPrice
      // 
      this.textBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.textBoxPrice.Location = new System.Drawing.Point(409, 182);
      this.textBoxPrice.Name = "textBoxPrice";
      this.textBoxPrice.Size = new System.Drawing.Size(234, 22);
      this.textBoxPrice.TabIndex = 6;
      // 
      // textBoxUnitType
      // 
      this.textBoxUnitType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.textBoxUnitType.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxUnitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxUnitType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.textBoxUnitType.Location = new System.Drawing.Point(409, 154);
      this.textBoxUnitType.Name = "textBoxUnitType";
      this.textBoxUnitType.Size = new System.Drawing.Size(234, 22);
      this.textBoxUnitType.TabIndex = 6;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.label7.Location = new System.Drawing.Point(252, 154);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(85, 24);
      this.label7.TabIndex = 7;
      this.label7.Text = "UnitType";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.label8.Location = new System.Drawing.Point(252, 210);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(126, 24);
      this.label8.TabIndex = 9;
      this.label8.Text = "Minutes to cut";
      // 
      // textBoxCutMinutes
      // 
      this.textBoxCutMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.textBoxCutMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxCutMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.textBoxCutMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.textBoxCutMinutes.Location = new System.Drawing.Point(409, 210);
      this.textBoxCutMinutes.Name = "textBoxCutMinutes";
      this.textBoxCutMinutes.Size = new System.Drawing.Size(234, 22);
      this.textBoxCutMinutes.TabIndex = 8;
      // 
      // comboBoxMaterialType
      // 
      this.comboBoxMaterialType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.comboBoxMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxMaterialType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.comboBoxMaterialType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.comboBoxMaterialType.FormattingEnabled = true;
      this.comboBoxMaterialType.Location = new System.Drawing.Point(409, 126);
      this.comboBoxMaterialType.Name = "comboBoxMaterialType";
      this.comboBoxMaterialType.Size = new System.Drawing.Size(234, 21);
      this.comboBoxMaterialType.TabIndex = 10;
      // 
      // frmMaterials
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.ClientSize = new System.Drawing.Size(808, 687);
      this.Controls.Add(this.comboBoxMaterialType);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.textBoxCutMinutes);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBoxUnitType);
      this.Controls.Add(this.textBoxPrice);
      this.Controls.Add(this.textBoxDepth);
      this.Controls.Add(this.textBoxWidth);
      this.Controls.Add(this.textBoxLength);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.dataGridViewMaterials);
      this.Controls.Add(this.btnCopyMaterial);
      this.Controls.Add(this.btnDeleteMaterial);
      this.Controls.Add(this.btnNewMaterial);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmMaterials";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.frmMaterials_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnNewMaterial;
    private System.Windows.Forms.Button btnDeleteMaterial;
    private System.Windows.Forms.Button btnCopyMaterial;
    private System.Windows.Forms.DataGridView dataGridViewMaterials;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBoxLength;
    private System.Windows.Forms.TextBox textBoxWidth;
    private System.Windows.Forms.TextBox textBoxDepth;
    private System.Windows.Forms.TextBox textBoxPrice;
    private System.Windows.Forms.TextBox textBoxUnitType;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBoxCutMinutes;
    private System.Windows.Forms.ComboBox comboBoxMaterialType;
  }
}