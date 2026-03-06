using System.ComponentModel.DataAnnotations;

namespace RazorPagesLab.Models;
using System.ComponentModel.DataAnnotations.Schema;

public class City
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "Date Visited")]
    public DateTime DateVisited { get; set; }
    [Display(Name = "State or Region")]
     public string? StateRegion  { get; set; }
    public string? Country { get; set; }
    public int Population { get; set; }
    public int DaysSpent { get; set; }

}