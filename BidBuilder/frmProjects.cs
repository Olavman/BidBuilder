using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BidBuilder.ProjectManagement;

namespace BidBuilder
{
  public partial class frmProjects : Form
  {
    public frmProjects()
    {
      InitializeComponent();
    }

    private void LoadProjects()
    {
      lstProjects.Items.Clear(); //Clear existing items if reloading

      //Example data fetch, replace with actual data fetching logic
      var projects = ProjectService.GetAllProjects(); //Assuimg a service that fethches all projects

      foreach (var project in projects)
      {
        var listViewItem = new ListViewItem(project.Name);
        listViewItem.SubItems.Add(project.Status);
        listViewItem.SubItems.Add(project.StartDate.ToShortDateString());
        listViewItem.Tag = project; //Tag holds the project object for easy access later
        lstProjects.Items.Add(listViewItem);
      }

      lstProjects.Refresh();
    }

    private void CreateProject (string projectName)
    {
      // Example of adding to a list, replace with your actual data handling
      var newProject = new Project
      {
        Name = projectName,
        Status = "Planning",
        StartDate = DateTime.Now,
      };
      ProjectService.AddProject(newProject);
    }

    private void DeleteProject (Project project)
    {
      ProjectService.RemoveProject(project);
    }

    private async void txtBoxProjectsSearch_Enter(object sender, EventArgs e)
    {
      await Task.Delay(10);
      txtBoxProjectsSearch.SelectAll();
    }

    private void txtBoxProjectsSearch_Leave(object sender, EventArgs e)
    {
      if (txtBoxProjectsSearch.Text == "")
      {
        txtBoxProjectsSearch.Text = "Search";
      }
      txtBoxProjectsSearch.DeselectAll();
    }

    private void frmProjects_Load(object sender, EventArgs e)
    {
      LoadProjects();
    }

    private void lstProjects_ItemActivate(object sender, EventArgs e)
    {
    }

    private void OpenProjectDetails(Project project)
    {
      lblProposal.Text = project.Proposal.ToString();
    }

    private void lstProjects_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
      if (lstProjects.SelectedItems.Count > 0)
      {
        var project = (Project)lstProjects.SelectedItems[0].Tag;
        OpenProjectDetails(project);
      }
    }

    private void btnNewProject_Click(object sender, EventArgs e)
    {
      using (var form = new frmNewProject())
      {
        form.StartPosition = FormStartPosition.CenterScreen;
        var result = form.ShowDialog();
        if (result == DialogResult.OK)
        {
          string projectName = form.ProjectName;
          CreateProject(projectName);
          LoadProjects();
          //DebugUtility.DebugMessage("Project created");
        }
      }
    }

    private void btnDeleteProject_MouseClick(object sender, MouseEventArgs e)
    {
      if (lstProjects.SelectedItems.Count > 0)
      {
        var project = (Project)lstProjects.SelectedItems[0].Tag;
        using (var form = new frmConfirmDelete())
        {
          form.StartPosition = FormStartPosition.CenterScreen;
          var result = form.ShowDialog();
          if(result == DialogResult.Yes)
          {
            DeleteProject(project);
            LoadProjects();
            //DebugUtility.DebugMessage("Project removed");
          }
        }
      }
    }
  }
}
