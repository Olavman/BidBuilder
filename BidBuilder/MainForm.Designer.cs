namespace BidBuilder
{
  partial class MainForm
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
      this.pnlNav = new System.Windows.Forms.Panel();
      this.btnSettings = new System.Windows.Forms.Button();
      this.btnMaterials = new System.Windows.Forms.Button();
      this.btnTemplates = new System.Windows.Forms.Button();
      this.btnProjects = new System.Windows.Forms.Button();
      this.btnDashboard = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.lblTitle = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.pnlDrag = new System.Windows.Forms.Panel();
      this.pnlFormLoader = new System.Windows.Forms.Panel();
      this.btnWorkspace = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.pnlDrag.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(9)))), ((int)(((byte)(23)))));
      this.panel1.Controls.Add(this.btnWorkspace);
      this.panel1.Controls.Add(this.pnlNav);
      this.panel1.Controls.Add(this.btnSettings);
      this.panel1.Controls.Add(this.btnMaterials);
      this.panel1.Controls.Add(this.btnTemplates);
      this.panel1.Controls.Add(this.btnProjects);
      this.panel1.Controls.Add(this.btnDashboard);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 42);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(200, 726);
      this.panel1.TabIndex = 0;
      // 
      // pnlNav
      // 
      this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
      this.pnlNav.Location = new System.Drawing.Point(3, 249);
      this.pnlNav.Name = "pnlNav";
      this.pnlNav.Size = new System.Drawing.Size(5, 100);
      this.pnlNav.TabIndex = 7;
      // 
      // btnSettings
      // 
      this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btnSettings.FlatAppearance.BorderSize = 0;
      this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
      this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.btnSettings.Location = new System.Drawing.Point(0, 684);
      this.btnSettings.Name = "btnSettings";
      this.btnSettings.Size = new System.Drawing.Size(200, 42);
      this.btnSettings.TabIndex = 6;
      this.btnSettings.Text = "Settings";
      this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnSettings.UseVisualStyleBackColor = true;
      this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
      // 
      // btnMaterials
      // 
      this.btnMaterials.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnMaterials.FlatAppearance.BorderSize = 0;
      this.btnMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMaterials.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
      this.btnMaterials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.btnMaterials.Location = new System.Drawing.Point(0, 333);
      this.btnMaterials.Name = "btnMaterials";
      this.btnMaterials.Size = new System.Drawing.Size(200, 42);
      this.btnMaterials.TabIndex = 5;
      this.btnMaterials.Text = "Materials";
      this.btnMaterials.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnMaterials.UseVisualStyleBackColor = true;
      this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
      // 
      // btnTemplates
      // 
      this.btnTemplates.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnTemplates.FlatAppearance.BorderSize = 0;
      this.btnTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTemplates.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
      this.btnTemplates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.btnTemplates.Location = new System.Drawing.Point(0, 291);
      this.btnTemplates.Name = "btnTemplates";
      this.btnTemplates.Size = new System.Drawing.Size(200, 42);
      this.btnTemplates.TabIndex = 4;
      this.btnTemplates.Text = "Templates";
      this.btnTemplates.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnTemplates.UseVisualStyleBackColor = true;
      this.btnTemplates.Click += new System.EventHandler(this.btnTemplates_Click);
      // 
      // btnProjects
      // 
      this.btnProjects.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnProjects.FlatAppearance.BorderSize = 0;
      this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnProjects.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
      this.btnProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.btnProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnProjects.Location = new System.Drawing.Point(0, 249);
      this.btnProjects.Name = "btnProjects";
      this.btnProjects.Size = new System.Drawing.Size(200, 42);
      this.btnProjects.TabIndex = 3;
      this.btnProjects.Text = "Projects";
      this.btnProjects.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnProjects.UseVisualStyleBackColor = true;
      this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
      // 
      // btnDashboard
      // 
      this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnDashboard.FlatAppearance.BorderSize = 0;
      this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.btnDashboard.Location = new System.Drawing.Point(0, 207);
      this.btnDashboard.Name = "btnDashboard";
      this.btnDashboard.Size = new System.Drawing.Size(200, 42);
      this.btnDashboard.TabIndex = 3;
      this.btnDashboard.Text = "Dashboard";
      this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnDashboard.UseVisualStyleBackColor = true;
      this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.pictureBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(200, 207);
      this.panel2.TabIndex = 2;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::BidBuilder.Properties.Resources.BidBuilderLogo1;
      this.pictureBox1.Location = new System.Drawing.Point(38, 39);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(122, 122);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(9)))), ((int)(((byte)(23)))));
      this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.lblTitle.Location = new System.Drawing.Point(194, 4);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(166, 33);
      this.lblTitle.TabIndex = 1;
      this.lblTitle.Text = "Dashboard";
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(9)))), ((int)(((byte)(23)))));
      this.btnClose.FlatAppearance.BorderSize = 0;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
      this.btnClose.Location = new System.Drawing.Point(987, 9);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(25, 25);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // pnlDrag
      // 
      this.pnlDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(9)))), ((int)(((byte)(23)))));
      this.pnlDrag.Controls.Add(this.btnClose);
      this.pnlDrag.Controls.Add(this.lblTitle);
      this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlDrag.Location = new System.Drawing.Point(0, 0);
      this.pnlDrag.Name = "pnlDrag";
      this.pnlDrag.Size = new System.Drawing.Size(1024, 42);
      this.pnlDrag.TabIndex = 4;
      this.pnlDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseDown);
      this.pnlDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseMove);
      this.pnlDrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseUp);
      // 
      // pnlFormLoader
      // 
      this.pnlFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlFormLoader.Location = new System.Drawing.Point(200, 42);
      this.pnlFormLoader.Name = "pnlFormLoader";
      this.pnlFormLoader.Size = new System.Drawing.Size(824, 726);
      this.pnlFormLoader.TabIndex = 5;
      this.pnlFormLoader.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlFormLoader_ControlAdded);
      // 
      // btnWorkspace
      // 
      this.btnWorkspace.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnWorkspace.FlatAppearance.BorderSize = 0;
      this.btnWorkspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnWorkspace.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
      this.btnWorkspace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.btnWorkspace.Location = new System.Drawing.Point(0, 375);
      this.btnWorkspace.Name = "btnWorkspace";
      this.btnWorkspace.Size = new System.Drawing.Size(200, 42);
      this.btnWorkspace.TabIndex = 8;
      this.btnWorkspace.Text = "Workspace";
      this.btnWorkspace.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnWorkspace.UseVisualStyleBackColor = true;
      this.btnWorkspace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnWorkspace_MouseClick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
      this.ClientSize = new System.Drawing.Size(1024, 768);
      this.Controls.Add(this.pnlFormLoader);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.pnlDrag);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MainForm";
      this.Text = " ";
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.pnlDrag.ResumeLayout(false);
      this.pnlDrag.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnDashboard;
    private System.Windows.Forms.Button btnProjects;
    private System.Windows.Forms.Button btnSettings;
    private System.Windows.Forms.Button btnMaterials;
    private System.Windows.Forms.Button btnTemplates;
    private System.Windows.Forms.Panel pnlNav;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Panel pnlDrag;
    private System.Windows.Forms.Panel pnlFormLoader;
    private System.Windows.Forms.Button btnWorkspace;
  }
}

