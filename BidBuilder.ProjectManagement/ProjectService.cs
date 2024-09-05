using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidBuilder.ProjectManagement
{
  public static class ProjectService
  {
    private static List<Project> projects = new List<Project>();

    public static void AddProject(Project project)
    {
      projects.Add(project);
    }
    public static void RemoveProject(Project project)
    {
      projects.Remove(project);
    }
    public static List<Project> GetAllProjects()
    {
      return projects;
    }
  }
}
