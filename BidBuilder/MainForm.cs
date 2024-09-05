using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace BidBuilder
{
  public partial class MainForm : Form
  {
    Color col1 = Color.FromArgb(3, 9, 23);
    Color col2 = Color.FromArgb(41, 49, 69);
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
      (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
      );

    private bool dragging = false;
    private Point dragCursorPoint;
    private Point dragFormPoint;

    public MainForm()
    {
      InitializeComponent();
      Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

      // Load Dashboard form at start
      lblTitle.Text = "Dashboard";
      this.pnlFormLoader.Controls.Clear();
      frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
      FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
      this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
      FrmDashboard_Vrb.Show();

      pnlNav.Height = btnDashboard.Height;
      pnlNav.Top = btnDashboard.Top;
      pnlNav.Left = btnDashboard.Left;
      btnDashboard.BackColor = col2;
    }


    private void ResetButtonColors()
    {
      btnDashboard.BackColor = col1;
      btnProjects.BackColor = col1;
      btnTemplates.BackColor = col1;
      btnMaterials.BackColor = col1;
      btnWorkspace.BackColor = col1;
      btnSettings.BackColor = col1;
    }
    private void pnlFormLoader_ControlAdded(object sender, ControlEventArgs e)
    {
      ResetButtonColors();
    }

    #region // Navigation
    private void LoadFormInPanel<T>(Button navButton, string titleText) where T : Form, new()
    {
      lblTitle.Text = titleText;
      this.pnlFormLoader.Controls.Clear();

      T form = new T()
      {
        Dock = DockStyle.Fill,
        TopLevel = false,
        TopMost = true,
        FormBorderStyle = FormBorderStyle.None
      };
      this.pnlFormLoader.Controls.Add(form);
      form.Show();

      pnlNav.Height = navButton.Height;
      pnlNav.Top = navButton.Top;
      pnlNav.Left = navButton.Left;
      navButton.BackColor = col2;
    }

    private void btnDashboard_Click(object sender, EventArgs e)
    {
      LoadFormInPanel<frmDashboard>(btnDashboard, "Dashboard");
    }

    private void btnProjects_Click(object sender, EventArgs e)
    {
      LoadFormInPanel<frmProjects>(btnProjects, "Projects");
    }

    private void btnTemplates_Click(object sender, EventArgs e)
    {
      LoadFormInPanel<frmTemplates>(btnTemplates, "Templates");
    }

    private void btnMaterials_Click(object sender, EventArgs e)
    {
      LoadFormInPanel<frmMaterials>(btnMaterials, "Materials");
    }
    private void btnWorkspace_MouseClick(object sender, MouseEventArgs e)
    {
      LoadFormInPanel<frmWorkspace>(btnWorkspace, "Workspace");
    }
    private void btnSettings_Click(object sender, EventArgs e)
    {
      LoadFormInPanel<frmSettings>(btnSettings, "Settings");
    }
    #endregion
    private void btnClose_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void pnlDrag_MouseDown(object sender, MouseEventArgs e)
    {
      dragging = true;
      dragCursorPoint = Cursor.Position;
      dragFormPoint = this.Location;
    }

    private void pnlDrag_MouseUp(object sender, MouseEventArgs e)
    {
        dragging = false;
    }

    private void pnlDrag_MouseMove(object sender, MouseEventArgs e)
    {
      if (dragging)
      {
        Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
        this.Location = Point.Add(dragFormPoint, new Size(dif));
      }
    }

  }
}
