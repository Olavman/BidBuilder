﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidBuilder.ProjectManagement
{
  public class Project
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public float Proposal {  get; set; }
  }
}
