using System.ComponentModel.DataAnnotations;

namespace RazorPagesCities.Models;

public class City
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    public DateTime DateVisited { get; set; }
     public string? StateRegion  { get; set; }
    public string? Country { get; set; }
    public int Population { get; set; }
    public int DaysSpent { get; set; }

}