using System;
using System.Collections.Generic;

namespace joins.Models
{
  public class Employee
  {
    public int Id { get; set; }
    public string Full_Name { get; set; }
    public int Salary { get; set; }
    public string Job_Position { get; set; }
    public int Phone_Extension { get; set; }
    public bool Full_Time { get; set; }
    public int Department_Id { get; set; }
    public Department Departments { get; set; }
  }
}