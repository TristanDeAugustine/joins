using System;
using System.Collections.Generic;

namespace joins.Models
{
  public class Department
  {
    public int Id { get; set; }
    public string Department_Name { get; set; }
    public List<Employee> Employee { get; set; }




  }
}