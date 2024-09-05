namespace BidBuilder
{
  partial class frmNewProject
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
      this.txtProjectName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtProjectName
      // 
      this.txtProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.txtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.txtProjectName.ForeColor = System.Drawing.SystemColors.Window;
      this.txtProjectName.Location = new System.Drawing.Point(12, 43);
      this.txtProjectName.Name = "txtProjectName";
      this.txtProjectName.Size = new System.Drawing.Size(225, 22);
      this.txtProjectName.TabIndex = 0;
      this.txtProjectName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProjectName_KeyPress);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(199, 30);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter project name";
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(9)))), ((int)(((byte)(23)))));
      this.btnClose.FlatAppearance.BorderSize = 0;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
      this.btnClose.Location = new System.Drawing.Point(217, 14);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(25, 25);
      this.btnClose.TabIndex = 4;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmNewProject
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(9)))), ((int)(((byte)(23)))));
      this.ClientSize = new System.Drawing.Size(249, 83);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtProjectName);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmNewProject";
      this.Text = "Form1";
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmNewProject_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmNewProject_MouseMove);
      this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmNewProject_MouseUp);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtProjectName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnClose;
  }
}