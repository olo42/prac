using System;

namespace com.github.olo42.prac.core.entities
{
  public class Appoinmtment
  {
    public Appoinmtment(DateTime startDate, DateTime endDate, Resource resource)
    {
      this.StartDate = startDate;
      this.EndDate = endDate;
      this.Resource = resource;

    }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Resource Resource { get; set; }
  }
}