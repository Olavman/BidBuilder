using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BidBuilder
{
  public partial class frmNewProject : Form
  {
    private bool dragging = false;
    private Point dragCursorPoint;
    private Point dragFormPoint;
    public string ProjectName 
    { 
      get{ return txtProjectName.Text;}
    }
    public frmNewProject()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }

    private void txtProjectName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Enter)
      {
        e.Handled = true; // Prevent the ding sound when pressing enter

        if (string.IsNullOrWhiteSpace(txtProjectName.Text))
        {
          MessageBox.Show("Please enter a project name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          this.DialogResult = DialogResult.None; // Keeps the form open
        }
        else
        {
          this.DialogResult = DialogResult.OK;
        }
      }
    }

    private void frmNewProject_MouseDown(object sender, MouseEventArgs e)
    {
      dragging = true;
      dragCursorPoint = Cursor.Position;
      dragFormPoint = this.Location;
    }

    private void frmNewProject_MouseUp(object sender, MouseEventArgs e)
    {
      dragging = false;
    }

    private void frmNewProject_MouseMove(object sender, MouseEventArgs e)
    {
      if (dragging)
      {
        Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
        this.Location = Point.Add(dragFormPoint, new Size(dif));
      }
    }
  }
}
