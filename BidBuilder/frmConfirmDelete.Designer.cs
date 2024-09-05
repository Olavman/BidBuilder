namespace BidBuilder
{
  partial class frmConfirmDelete
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
      this.label1 = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnYes = new System.Windows.Forms.Button();
      this.btnNo = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(453, 30);
      this.label1.TabIndex = 2;
      this.label1.Text = "Are you sure you want to delete this project?";
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(9)))), ((int)(((byte)(23)))));
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.FlatAppearance.BorderSize = 0;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
      this.btnClose.Location = new System.Drawing.Point(471, 15);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(25, 25);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      // 
      // btnYes
      // 
      this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
      this.btnYes.FlatAppearance.BorderSize = 0;
      this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.btnYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.btnYes.Location = new System.Drawing.Point(118, 64);
      this.btnYes.Name = "btnYes";
      this.btnYes.Size = new System.Drawing.Size(66, 34);
      this.btnYes.TabIndex = 6;
      this.btnYes.Text = "Yes";
      this.btnYes.UseVisualStyleBackColor = false;
      // 
      // btnNo
      // 
      this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
      this.btnNo.FlatAppearance.BorderSize = 0;
      this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.btnNo.Location = new System.Drawing.Point(291, 64);
      this.btnNo.Name = "btnNo";
      this.btnNo.Size = new System.Drawing.Size(66, 34);
      this.btnNo.TabIndex = 7;
      this.btnNo.Text = "No";
      this.btnNo.UseVisualStyleBackColor = false;
      // 
      // frmConfirmDelete
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(9)))), ((int)(((byte)(23)))));
      this.ClientSize = new System.Drawing.Size(501, 136);
      this.Controls.Add(this.btnNo);
      this.Controls.Add(this.btnYes);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmConfirmDelete";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnYes;
    private System.Windows.Forms.Button btnNo;
  }
}