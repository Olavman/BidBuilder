namespace BidBuilder
{
  partial class frmProjects
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
      this.txtBoxProjectsSearch = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.lblProposal = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnNewProject = new System.Windows.Forms.Button();
      this.btnDeleteProject = new System.Windows.Forms.Button();
      this.lstProjects = new System.Windows.Forms.ListView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
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
      this.txtBoxProjectsSearch.TabIndex = 3;
      this.txtBoxProjectsSearch.Text = "Search";
      this.txtBoxProjectsSearch.Enter += new System.EventHandler(this.txtBoxProjectsSearch_Enter);
      this.txtBoxProjectsSearch.Leave += new System.EventHandler(this.txtBoxProjectsSearch_Leave);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.panel2.Controls.Add(this.lblProposal);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Location = new System.Drawing.Point(206, 64);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(278, 181);
      this.panel2.TabIndex = 4;
      // 
      // lblProposal
      // 
      this.lblProposal.AutoSize = true;
      this.lblProposal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblProposal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.lblProposal.Location = new System.Drawing.Point(56, 81);
      this.lblProposal.Name = "lblProposal";
      this.lblProposal.Size = new System.Drawing.Size(20, 24);
      this.lblProposal.TabIndex = 1;
      this.lblProposal.Text = "0";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.label1.Location = new System.Drawing.Point(28, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(121, 31);
      this.label1.TabIndex = 0;
      this.label1.Text = "Proposal";
      // 
      // btnNewProject
      // 
      this.btnNewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.btnNewProject.FlatAppearance.BorderSize = 0;
      this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.btnNewProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.btnNewProject.Location = new System.Drawing.Point(206, 12);
      this.btnNewProject.Name = "btnNewProject";
      this.btnNewProject.Size = new System.Drawing.Size(140, 35);
      this.btnNewProject.TabIndex = 5;
      this.btnNewProject.Text = "New project";
      this.btnNewProject.UseVisualStyleBackColor = false;
      this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
      // 
      // btnDeleteProject
      // 
      this.btnDeleteProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.btnDeleteProject.FlatAppearance.BorderSize = 0;
      this.btnDeleteProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
      this.btnDeleteProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.btnDeleteProject.Location = new System.Drawing.Point(352, 12);
      this.btnDeleteProject.Name = "btnDeleteProject";
      this.btnDeleteProject.Size = new System.Drawing.Size(140, 35);
      this.btnDeleteProject.TabIndex = 6;
      this.btnDeleteProject.Text = "Delete project";
      this.btnDeleteProject.UseVisualStyleBackColor = false;
      this.btnDeleteProject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDeleteProject_MouseClick);
      // 
      // lstProjects
      // 
      this.lstProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
      this.lstProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.lstProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.lstProjects.FullRowSelect = true;
      this.lstProjects.HideSelection = false;
      this.lstProjects.Location = new System.Drawing.Point(12, 64);
      this.lstProjects.MultiSelect = false;
      this.lstProjects.Name = "lstProjects";
      this.lstProjects.Size = new System.Drawing.Size(176, 650);
      this.lstProjects.TabIndex = 0;
      this.lstProjects.UseCompatibleStateImageBehavior = false;
      this.lstProjects.View = System.Windows.Forms.View.List;
      this.lstProjects.ItemActivate += new System.EventHandler(this.lstProjects_ItemActivate);
      this.lstProjects.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstProjects_ItemSelectionChanged);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lstProjects);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(200, 726);
      this.panel1.TabIndex = 1;
      // 
      // frmProjects
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.ClientSize = new System.Drawing.Size(824, 726);
      this.Controls.Add(this.btnDeleteProject);
      this.Controls.Add(this.btnNewProject);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.txtBoxProjectsSearch);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmProjects";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.frmProjects_Load);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox txtBoxProjectsSearch;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblProposal;
    private System.Windows.Forms.Button btnNewProject;
    private System.Windows.Forms.Button btnDeleteProject;
    private System.Windows.Forms.ListView lstProjects;
    private System.Windows.Forms.Panel panel1;
  }
}