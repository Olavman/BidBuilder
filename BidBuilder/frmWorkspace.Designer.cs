namespace BidBuilder
{
  partial class frmWorkspace
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.txtBoxProjectsSearch = new System.Windows.Forms.TextBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.treeView1);
      this.panel1.Controls.Add(this.txtBoxProjectsSearch);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(200, 726);
      this.panel1.TabIndex = 2;
      // 
      // treeView1
      // 
      this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.treeView1.Location = new System.Drawing.Point(12, 64);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(176, 650);
      this.treeView1.TabIndex = 3;
      // 
      // txtBoxProjectsSearch
      // 
      this.txtBoxProjectsSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.txtBoxProjectsSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtBoxProjectsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxProjectsSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.txtBoxProjectsSearch.Location = new System.Drawing.Point(12, 12);
      this.txtBoxProjectsSearch.Multiline = true;
      this.txtBoxProjectsSearch.Name = "txtBoxProjectsSearch";
      this.txtBoxProjectsSearch.Size = new System.Drawing.Size(176, 26);
      this.txtBoxProjectsSearch.TabIndex = 4;
      this.txtBoxProjectsSearch.Text = "Search";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(320, 104);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 3;
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(360, 173);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(120, 95);
      this.listBox1.TabIndex = 4;
      // 
      // frmWorkspace
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.ClientSize = new System.Drawing.Size(824, 726);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.panel1);
      this.Cursor = System.Windows.Forms.Cursors.Default;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmWorkspace";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.frmWorkspace_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtBoxProjectsSearch;
    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.ListBox listBox1;
  }
}